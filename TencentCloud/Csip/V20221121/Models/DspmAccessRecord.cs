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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspmAccessRecord : AbstractModel
    {
        
        /// <summary>
        /// 资产信息
        /// </summary>
        [JsonProperty("Asset")]
        public DspmDbAsset Asset{ get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        [JsonProperty("Accounts")]
        public DspmAssetAccount[] Accounts{ get; set; }

        /// <summary>
        /// 来源ip信息
        /// </summary>
        [JsonProperty("SourceIpList")]
        public DspmIp[] SourceIpList{ get; set; }

        /// <summary>
        /// 记录时间
        /// </summary>
        [JsonProperty("RecordTime")]
        public string RecordTime{ get; set; }

        /// <summary>
        /// 登录成功次数
        /// </summary>
        [JsonProperty("LoginSuccessCount")]
        public long? LoginSuccessCount{ get; set; }

        /// <summary>
        /// 登录失败次数
        /// </summary>
        [JsonProperty("LoginFailedCount")]
        public long? LoginFailedCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Asset.", this.Asset);
            this.SetParamArrayObj(map, prefix + "Accounts.", this.Accounts);
            this.SetParamArrayObj(map, prefix + "SourceIpList.", this.SourceIpList);
            this.SetParamSimple(map, prefix + "RecordTime", this.RecordTime);
            this.SetParamSimple(map, prefix + "LoginSuccessCount", this.LoginSuccessCount);
            this.SetParamSimple(map, prefix + "LoginFailedCount", this.LoginFailedCount);
        }
    }
}

