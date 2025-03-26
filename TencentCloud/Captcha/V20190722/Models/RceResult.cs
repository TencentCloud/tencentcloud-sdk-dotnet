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

namespace TencentCloud.Captcha.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RceResult : AbstractModel
    {
        
        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 操作时间戳
        /// </summary>
        [JsonProperty("PostTime")]
        public long? PostTime{ get; set; }

        /// <summary>
        /// 业务参数
        /// </summary>
        [JsonProperty("AssociateAccount")]
        public string AssociateAccount{ get; set; }

        /// <summary>
        /// 用户Ip
        /// </summary>
        [JsonProperty("UserIp")]
        public string UserIp{ get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// 风险类型
        /// </summary>
        [JsonProperty("RiskType")]
        public long?[] RiskType{ get; set; }

        /// <summary>
        /// 设备唯一ID
        /// </summary>
        [JsonProperty("ConstId")]
        public string ConstId{ get; set; }

        /// <summary>
        /// 风险扩展参数
        /// </summary>
        [JsonProperty("RiskInformation")]
        public string RiskInformation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "PostTime", this.PostTime);
            this.SetParamSimple(map, prefix + "AssociateAccount", this.AssociateAccount);
            this.SetParamSimple(map, prefix + "UserIp", this.UserIp);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamArraySimple(map, prefix + "RiskType.", this.RiskType);
            this.SetParamSimple(map, prefix + "ConstId", this.ConstId);
            this.SetParamSimple(map, prefix + "RiskInformation", this.RiskInformation);
        }
    }
}

