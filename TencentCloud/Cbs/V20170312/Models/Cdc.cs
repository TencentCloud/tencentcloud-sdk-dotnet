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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Cdc : AbstractModel
    {
        
        /// <summary>
        /// 独享集群围笼ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CageId")]
        public string CageId{ get; set; }

        /// <summary>
        /// 独享集群状态。取值范围：<br><li>NORMAL:正常<br><li>CLOSED：关闭售卖<br><li>FAULT：状态异常<br><li>ISOLATED：已隔离。
        /// </summary>
        [JsonProperty("CdcState")]
        public string CdcState{ get; set; }

        /// <summary>
        /// 独享集群所属的[可用区](/document/api/213/9452#zone)ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 独享集群实例名称。
        /// </summary>
        [JsonProperty("CdcName")]
        public string CdcName{ get; set; }

        /// <summary>
        /// 独享集群的资源大小。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CdcResource")]
        public CdcSize CdcResource{ get; set; }

        /// <summary>
        /// 独享集群实例id。
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }

        /// <summary>
        /// 独享集群类型。取值范围：<br><li>CLOUD_BASIC：表示普通云硬盘集群<br><li>CLOUD_PREMIUM：表示高性能云硬盘集群<br><li>CLOUD_SSD：SSD表示SSD云硬盘集群。
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// 独享集群过期时间。
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CageId", this.CageId);
            this.SetParamSimple(map, prefix + "CdcState", this.CdcState);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "CdcName", this.CdcName);
            this.SetParamObj(map, prefix + "CdcResource.", this.CdcResource);
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
        }
    }
}

