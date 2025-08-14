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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WebCallback : AbstractModel
    {
        
        /// <summary>
        /// 回调的类型。可选值：
        /// - Http(自定义接口回调)
        /// - WeCom(企业微信)
        /// - DingTalk(钉钉)
        /// - Lark(飞书)
        /// </summary>
        [JsonProperty("CallbackType")]
        public string CallbackType{ get; set; }

        /// <summary>
        /// 回调地址，最大支持1024个字节。
        /// 也可使用WebCallbackId引用集成配置中的URL，此时该字段请填写为空字符串。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 集成配置ID。-通过[获取告警渠道回调配置列表](https://cloud.tencent.com/document/product/614/115229)获取集成配置ID
        /// </summary>
        [JsonProperty("WebCallbackId")]
        public string WebCallbackId{ get; set; }

        /// <summary>
        /// 回调方法。可选值：
        /// - POST（默认值）
        /// - PUT
        /// 
        /// 注意：
        /// - 参数CallbackType为Http时为必选，其它回调方式无需填写。
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// 通知内容模板ID，使用Default-zh引用默认模板（中文），使用Default-en引用DefaultTemplate(English)。
        /// </summary>
        [JsonProperty("NoticeContentId")]
        public string NoticeContentId{ get; set; }

        /// <summary>
        /// 提醒类型。
        /// 
        /// 0：不提醒；1：指定人；2：所有人
        /// </summary>
        [JsonProperty("RemindType")]
        public ulong? RemindType{ get; set; }

        /// <summary>
        /// 电话列表。
        /// </summary>
        [JsonProperty("Mobiles")]
        public string[] Mobiles{ get; set; }

        /// <summary>
        /// 用户ID列表。
        /// </summary>
        [JsonProperty("UserIds")]
        public string[] UserIds{ get; set; }

        /// <summary>
        /// 该参数已废弃，请使用NoticeContentId。
        /// </summary>
        [JsonProperty("Headers")]
        [System.Obsolete]
        public string[] Headers{ get; set; }

        /// <summary>
        /// 该参数已废弃，请使用NoticeContentId。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Body")]
        [System.Obsolete]
        public string Body{ get; set; }

        /// <summary>
        /// 序号。
        /// - 入参无效。
        /// - 出参有效。
        /// </summary>
        [JsonProperty("Index")]
        public long? Index{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CallbackType", this.CallbackType);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "WebCallbackId", this.WebCallbackId);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "NoticeContentId", this.NoticeContentId);
            this.SetParamSimple(map, prefix + "RemindType", this.RemindType);
            this.SetParamArraySimple(map, prefix + "Mobiles.", this.Mobiles);
            this.SetParamArraySimple(map, prefix + "UserIds.", this.UserIds);
            this.SetParamArraySimple(map, prefix + "Headers.", this.Headers);
            this.SetParamSimple(map, prefix + "Body", this.Body);
            this.SetParamSimple(map, prefix + "Index", this.Index);
        }
    }
}

