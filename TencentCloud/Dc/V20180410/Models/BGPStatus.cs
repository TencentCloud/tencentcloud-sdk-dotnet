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

namespace TencentCloud.Dc.V20180410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BGPStatus : AbstractModel
    {
        
        /// <summary>
        /// 腾讯侧主互联IP BGP状态
        /// </summary>
        [JsonProperty("TencentAddressBgpState")]
        public string TencentAddressBgpState{ get; set; }

        /// <summary>
        /// 腾讯侧备互联IP BGP状态
        /// </summary>
        [JsonProperty("TencentBackupAddressBgpState")]
        public string TencentBackupAddressBgpState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TencentAddressBgpState", this.TencentAddressBgpState);
            this.SetParamSimple(map, prefix + "TencentBackupAddressBgpState", this.TencentBackupAddressBgpState);
        }
    }
}

