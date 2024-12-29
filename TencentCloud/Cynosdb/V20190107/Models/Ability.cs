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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Ability : AbstractModel
    {
        
        /// <summary>
        /// 是否支持从可用区
        /// </summary>
        [JsonProperty("IsSupportSlaveZone")]
        public string IsSupportSlaveZone{ get; set; }

        /// <summary>
        /// 不支持从可用区的原因
        /// </summary>
        [JsonProperty("NonsupportSlaveZoneReason")]
        public string NonsupportSlaveZoneReason{ get; set; }

        /// <summary>
        /// 是否支持RO实例
        /// </summary>
        [JsonProperty("IsSupportRo")]
        public string IsSupportRo{ get; set; }

        /// <summary>
        /// 不支持RO实例的原因
        /// </summary>
        [JsonProperty("NonsupportRoReason")]
        public string NonsupportRoReason{ get; set; }

        /// <summary>
        /// 是否支持手动发起快照备份
        /// </summary>
        [JsonProperty("IsSupportManualSnapshot")]
        public string IsSupportManualSnapshot{ get; set; }

        /// <summary>
        /// 是否支持透明数据加密
        /// </summary>
        [JsonProperty("IsSupportTransparentDataEncryption")]
        public string IsSupportTransparentDataEncryption{ get; set; }

        /// <summary>
        /// 不支持透明数据加密原因
        /// </summary>
        [JsonProperty("NoSupportTransparentDataEncryptionReason")]
        public string NoSupportTransparentDataEncryptionReason{ get; set; }

        /// <summary>
        /// 是否支持手动发起逻辑备份
        /// </summary>
        [JsonProperty("IsSupportManualLogic")]
        public string IsSupportManualLogic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsSupportSlaveZone", this.IsSupportSlaveZone);
            this.SetParamSimple(map, prefix + "NonsupportSlaveZoneReason", this.NonsupportSlaveZoneReason);
            this.SetParamSimple(map, prefix + "IsSupportRo", this.IsSupportRo);
            this.SetParamSimple(map, prefix + "NonsupportRoReason", this.NonsupportRoReason);
            this.SetParamSimple(map, prefix + "IsSupportManualSnapshot", this.IsSupportManualSnapshot);
            this.SetParamSimple(map, prefix + "IsSupportTransparentDataEncryption", this.IsSupportTransparentDataEncryption);
            this.SetParamSimple(map, prefix + "NoSupportTransparentDataEncryptionReason", this.NoSupportTransparentDataEncryptionReason);
            this.SetParamSimple(map, prefix + "IsSupportManualLogic", this.IsSupportManualLogic);
        }
    }
}

