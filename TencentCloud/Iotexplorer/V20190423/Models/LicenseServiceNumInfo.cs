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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LicenseServiceNumInfo : AbstractModel
    {
        
        /// <summary>
        /// 服务类型
        /// </summary>
        [JsonProperty("LicenseType")]
        public string LicenseType{ get; set; }

        /// <summary>
        /// 授权总数
        /// </summary>
        [JsonProperty("TotalNum")]
        public long? TotalNum{ get; set; }

        /// <summary>
        /// 已使用授权数
        /// </summary>
        [JsonProperty("UsedNum")]
        public long? UsedNum{ get; set; }

        /// <summary>
        /// TWeCall激活码
        /// </summary>
        [JsonProperty("TWeCallLicense")]
        public TWeCallLicenseInfo[] TWeCallLicense{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LicenseType", this.LicenseType);
            this.SetParamSimple(map, prefix + "TotalNum", this.TotalNum);
            this.SetParamSimple(map, prefix + "UsedNum", this.UsedNum);
            this.SetParamArrayObj(map, prefix + "TWeCallLicense.", this.TWeCallLicense);
        }
    }
}

