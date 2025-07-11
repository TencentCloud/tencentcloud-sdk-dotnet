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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AnycastOutPackRelation : AbstractModel
    {
        
        /// <summary>
        /// 业务带宽(单位M)
        /// </summary>
        [JsonProperty("NormalBandwidth")]
        public ulong? NormalBandwidth{ get; set; }

        /// <summary>
        /// 转发规则数
        /// </summary>
        [JsonProperty("ForwardRulesLimit")]
        public ulong? ForwardRulesLimit{ get; set; }

        /// <summary>
        /// 自动续费标记
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        [JsonProperty("CurDeadline")]
        public string CurDeadline{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NormalBandwidth", this.NormalBandwidth);
            this.SetParamSimple(map, prefix + "ForwardRulesLimit", this.ForwardRulesLimit);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "CurDeadline", this.CurDeadline);
        }
    }
}

