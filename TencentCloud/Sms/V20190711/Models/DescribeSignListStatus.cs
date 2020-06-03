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

namespace TencentCloud.Sms.V20190711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSignListStatus : AbstractModel
    {
        
        /// <summary>
        /// 签名Id
        /// </summary>
        [JsonProperty("SignId")]
        public ulong? SignId{ get; set; }

        /// <summary>
        /// 是否国际/港澳台短信：
        /// 0：表示国内短信。
        /// 1：表示国际/港澳台短信。
        /// </summary>
        [JsonProperty("International")]
        public ulong? International{ get; set; }

        /// <summary>
        /// 申请签名状态。其中：
        /// 0：表示审核通过。
        /// 1：表示审核中。
        /// -1：表示审核未通过或审核失败。
        /// </summary>
        [JsonProperty("StatusCode")]
        public long? StatusCode{ get; set; }

        /// <summary>
        /// 审核回复，审核人员审核后给出的回复，通常是审核未通过的原因。
        /// </summary>
        [JsonProperty("ReviewReply")]
        public string ReviewReply{ get; set; }

        /// <summary>
        /// 签名名称。
        /// </summary>
        [JsonProperty("SignName")]
        public string SignName{ get; set; }

        /// <summary>
        /// 提交审核时间，UNIX 时间戳（单位：秒）。
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SignId", this.SignId);
            this.SetParamSimple(map, prefix + "International", this.International);
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "ReviewReply", this.ReviewReply);
            this.SetParamSimple(map, prefix + "SignName", this.SignName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

