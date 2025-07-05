/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Solar.V20181011.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SendWxTouchTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 客户分组ID
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 去除今日已发送的客户
        /// </summary>
        [JsonProperty("DistinctFlag")]
        public bool? DistinctFlag{ get; set; }

        /// <summary>
        /// 是否立马发送
        /// </summary>
        [JsonProperty("IsSendNow")]
        public bool? IsSendNow{ get; set; }

        /// <summary>
        /// 发送时间，一般为0
        /// </summary>
        [JsonProperty("SendDate")]
        public long? SendDate{ get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 微信触达类型，text, news, smallapp, tmplmsg
        /// </summary>
        [JsonProperty("WxTouchType")]
        public string WxTouchType{ get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 文本内容
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 图文素材ID
        /// </summary>
        [JsonProperty("NewsId")]
        public string NewsId{ get; set; }

        /// <summary>
        /// 小程序卡片ID
        /// </summary>
        [JsonProperty("SmallProgramId")]
        public string SmallProgramId{ get; set; }

        /// <summary>
        /// 模板消息ID
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 微信公众号appId
        /// </summary>
        [JsonProperty("WxAppId")]
        public string WxAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "DistinctFlag", this.DistinctFlag);
            this.SetParamSimple(map, prefix + "IsSendNow", this.IsSendNow);
            this.SetParamSimple(map, prefix + "SendDate", this.SendDate);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "WxTouchType", this.WxTouchType);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "NewsId", this.NewsId);
            this.SetParamSimple(map, prefix + "SmallProgramId", this.SmallProgramId);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "WxAppId", this.WxAppId);
        }
    }
}

