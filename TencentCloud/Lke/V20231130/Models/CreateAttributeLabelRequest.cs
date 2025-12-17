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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAttributeLabelRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID，获取方法参看如何获取[BotBizId](https://cloud.tencent.com/document/product/1759/109469#4eecb8c1-6ce4-45f5-8fa2-b269449d8efa)
        /// </summary>
        [JsonProperty("BotBizId")]
        public string BotBizId{ get; set; }

        /// <summary>
        /// 标签名
        /// </summary>
        [JsonProperty("AttrName")]
        public string AttrName{ get; set; }

        /// <summary>
        /// 标签值
        /// </summary>
        [JsonProperty("Labels")]
        public AttributeLabel[] Labels{ get; set; }

        /// <summary>
        /// 标签标识（不生效，无需填写） 已作废
        /// </summary>
        [JsonProperty("AttrKey")]
        public string AttrKey{ get; set; }

        /// <summary>
        /// 登录用户主账号(集成商模式必填)
        /// </summary>
        [JsonProperty("LoginUin")]
        public string LoginUin{ get; set; }

        /// <summary>
        /// 登录用户子账号(集成商模式必填)
        /// </summary>
        [JsonProperty("LoginSubAccountUin")]
        public string LoginSubAccountUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BotBizId", this.BotBizId);
            this.SetParamSimple(map, prefix + "AttrName", this.AttrName);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamSimple(map, prefix + "AttrKey", this.AttrKey);
            this.SetParamSimple(map, prefix + "LoginUin", this.LoginUin);
            this.SetParamSimple(map, prefix + "LoginSubAccountUin", this.LoginSubAccountUin);
        }
    }
}

