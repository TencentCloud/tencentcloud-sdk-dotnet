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

namespace TencentCloud.Thpc.V20230321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyWorkspacesChargeTypeRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>工作空间 ID 列表。每次请求的工作空间计费模式必须一致。</p>
        /// </summary>
        [JsonProperty("SpaceIds")]
        public string[] SpaceIds{ get; set; }

        /// <summary>
        /// <p>转换的目标计费模式。当前仅支持 PREPAID（按量计费转包年包月）。</p>
        /// </summary>
        [JsonProperty("SpaceChargeType")]
        public string SpaceChargeType{ get; set; }

        /// <summary>
        /// <p>是否只进行参数和资源预检。true：不发起询价、组单或正式下单；false：执行对应操作。默认为 false。</p>
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// <p>预付费参数。Period 和 RenewFlag 均为可选字段；未传入时后端使用默认值 Period=1、RenewFlag=NOTIFY_AND_MANUAL_RENEW。</p>
        /// </summary>
        [JsonProperty("SpaceChargePrepaid")]
        public SpaceChargePrepaid SpaceChargePrepaid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SpaceIds.", this.SpaceIds);
            this.SetParamSimple(map, prefix + "SpaceChargeType", this.SpaceChargeType);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamObj(map, prefix + "SpaceChargePrepaid.", this.SpaceChargePrepaid);
        }
    }
}

