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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VersionWhiteConfig : AbstractModel
    {
        
        /// <summary>
        /// 到期天数
        /// </summary>
        [JsonProperty("Deadline")]
        public ulong? Deadline{ get; set; }

        /// <summary>
        /// 授权数量
        /// </summary>
        [JsonProperty("LicenseNum")]
        public ulong? LicenseNum{ get; set; }

        /// <summary>
        /// 是否可申请
        /// </summary>
        [JsonProperty("IsApplyFor")]
        public bool? IsApplyFor{ get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("SourceType")]
        public ulong? SourceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "LicenseNum", this.LicenseNum);
            this.SetParamSimple(map, prefix + "IsApplyFor", this.IsApplyFor);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
        }
    }
}

