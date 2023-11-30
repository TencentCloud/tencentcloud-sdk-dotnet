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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateIdsWhiteRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 入侵防御规则ID
        /// </summary>
        [JsonProperty("IdsRuleId")]
        public string IdsRuleId{ get; set; }

        /// <summary>
        /// 白名单类型：
        /// src 针对源放通
        /// dst 针对目的放通
        /// srcdst 针对源和目的放通
        /// </summary>
        [JsonProperty("WhiteRuleType")]
        public string WhiteRuleType{ get; set; }

        /// <summary>
        /// 白名单生效防火墙范围：
        /// 1 边界防火墙
        /// 2 nat防火墙
        /// 4 vpc防火墙
        /// 7 = 1+2+4  所有防火墙
        /// </summary>
        [JsonProperty("FwType")]
        public long? FwType{ get; set; }

        /// <summary>
        /// 源IP
        /// </summary>
        [JsonProperty("SrcIp")]
        public string SrcIp{ get; set; }

        /// <summary>
        /// 目的IP
        /// </summary>
        [JsonProperty("DstIp")]
        public string DstIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdsRuleId", this.IdsRuleId);
            this.SetParamSimple(map, prefix + "WhiteRuleType", this.WhiteRuleType);
            this.SetParamSimple(map, prefix + "FwType", this.FwType);
            this.SetParamSimple(map, prefix + "SrcIp", this.SrcIp);
            this.SetParamSimple(map, prefix + "DstIp", this.DstIp);
        }
    }
}

