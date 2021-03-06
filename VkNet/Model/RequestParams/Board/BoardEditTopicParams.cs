﻿using Newtonsoft.Json;
using VkNet.Utils;

namespace VkNet.Model.RequestParams
{
	/// <summary>
	/// Параметры метода wall.addComment
	/// </summary>
	public class BoardEditTopicParams
	{
        /// <summary>
        /// Идентификатор сообщества, в котором находится обсуждение.положительное число, обязательный параметр
        /// </summary>
        [JsonProperty("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// Идентификатор сообщества, в котором находится обсуждение.положительное число, обязательный параметр
        /// </summary>
        [JsonProperty("topic_id")]
        public long TopicId { get; set; }

        /// <summary>
        /// Новое название обсуждения. Обязательный параметр. 
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

		/// <summary>
		/// Идентификатор капчи
		/// </summary>
		[JsonProperty("captcha_sid")]
		public long? CaptchaSid { get; set; }

		/// <summary>
		/// Текст, который ввел пользователь
		/// </summary>
		[JsonProperty("captcha_key")]
		public string CaptchaKey { get; set; }

		/// <summary>
		/// Привести к типу VkParameters.
		/// </summary>
		/// <param name="p">Параметры.</param>
		/// <returns></returns>
		public static VkParameters ToVkParameters(BoardEditTopicParams p)
		{
			var parameters = new VkParameters
			{
				{ "group_id", p.GroupId },
				{ "topic_id", p.TopicId },
                { "title", p.Title },
                { "captcha_sid", p.CaptchaSid},
                { "captcha_key", p.CaptchaKey}
			};

			return parameters;
		}
	}
}