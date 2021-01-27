/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Rce.V20201103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OnlineScamInfo : AbstractModel
    {
        
        /// <summary>
        /// 内容标签。
        /// </summary>
        [JsonProperty("ContentLabel")]
        public string ContentLabel{ get; set; }

        /// <summary>
        /// 内容风险等级：
        /// 0：正常。
        /// 1：可疑。
        /// </summary>
        [JsonProperty("ContentRiskLevel")]
        public long? ContentRiskLevel{ get; set; }

        /// <summary>
        /// 内容产生形式：
        /// 0：对话。
        /// 1：广播。
        /// </summary>
        [JsonProperty("ContentType")]
        public long? ContentType{ get; set; }

        /// <summary>
        /// 诈骗账号类型：
        /// 1：11位手机号。
        /// 2：QQ账号。
        /// </summary>
        [JsonProperty("FraudType")]
        public long? FraudType{ get; set; }

        /// <summary>
        /// 诈骗账号，手机号或QQ账号。
        /// </summary>
        [JsonProperty("FraudAccount")]
        public string FraudAccount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ContentLabel", this.ContentLabel);
            this.SetParamSimple(map, prefix + "ContentRiskLevel", this.ContentRiskLevel);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamSimple(map, prefix + "FraudType", this.FraudType);
            this.SetParamSimple(map, prefix + "FraudAccount", this.FraudAccount);
        }
    }
}

