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

namespace TencentCloud.Thpc.V20230321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SpaceDataDisk : AbstractModel
    {
        
        /// <summary>
        /// 数据盘类型。数据盘类型限制详见[存储概述](https://cloud.tencent.com/document/product/213/4952)。取值范围：<br />
        /// <li>
        ///   LOCAL_BASIC：本地硬盘<br />
        ///   <li>
        ///     LOCAL_SSD：本地SSD硬盘<br />
        ///     <li>
        ///       LOCAL_NVME：本地NVME硬盘，与InstanceType强相关，不支持指定<br />
        ///       <li>
        ///         LOCAL_PRO：本地HDD硬盘，与InstanceType强相关，不支持指定<br />
        ///         <li>
        ///           CLOUD_BASIC：普通云硬盘<br />
        ///           <li>
        ///             CLOUD_PREMIUM：高性能云硬盘<br />
        ///             <li>
        ///               CLOUD_SSD：SSD云硬盘<br />
        ///               <li>
        ///                 CLOUD_HSSD：增强型SSD云硬盘<br />
        ///                 <li>
        ///                   CLOUD_TSSD：极速型SSD云硬盘<br />
        ///                   <li>
        ///                     CLOUD_BSSD：通用型SSD云硬盘<br /><br />默认取值：LOCAL_BASIC。<br /><br />该参数对`ResizeInstanceDisk`接口无效。
        ///                   </li>
        ///                 </li>
        ///               </li>
        ///             </li>
        ///           </li>
        ///         </li>
        ///       </li>
        ///     </li>
        ///   </li>
        /// </li>
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// 数据盘
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// 数据盘大小，单位：GB。最小调整步长为10G，不同数据盘类型取值范围不同，具体限制详见：[存储概述](https://cloud.tencent.com/document/product/213/4952)。默认值为0，表示不购买数据盘。更多限制详见产品文档。
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// 数据盘是否随子机销毁。取值范围：
        /// <li>TRUE：子机销毁时，销毁数据盘，只支持按小时后付费云盘</li>
        /// <li>
        ///   FALSE：子机销毁时，保留数据盘<br />
        ///   默认取值：TRUE<br />
        ///   该参数目前仅用于 `RunInstances` 接口。
        /// </li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeleteWithInstance")]
        public bool? DeleteWithInstance{ get; set; }

        /// <summary>
        /// 数据盘快照ID。选择的数据盘快照大小需小于数据盘大小。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SnapshotId")]
        public string SnapshotId{ get; set; }

        /// <summary>
        /// 数据盘是加密。取值范围：
        /// <li>true：加密</li>
        /// <li>
        ///   false：不加密<br />
        ///   默认取值：false<br />
        ///   该参数目前仅用于 `RunInstances` 接口。
        /// </li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Encrypt")]
        public bool? Encrypt{ get; set; }

        /// <summary>
        /// 自定义CMK对应的ID，取值为UUID或者类似kms-abcd1234。用于加密云盘。
        /// 
        /// 该参数目前仅用于 `CreateWorkspaces` 接口。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }

        /// <summary>
        /// 云硬盘性能，单位：MB/s
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ThroughputPerformance")]
        public long? ThroughputPerformance{ get; set; }

        /// <summary>
        /// 突发性能
        /// 
        /// 注：内测中。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BurstPerformance")]
        public bool? BurstPerformance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskId", this.DiskId);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "DeleteWithInstance", this.DeleteWithInstance);
            this.SetParamSimple(map, prefix + "SnapshotId", this.SnapshotId);
            this.SetParamSimple(map, prefix + "Encrypt", this.Encrypt);
            this.SetParamSimple(map, prefix + "KmsKeyId", this.KmsKeyId);
            this.SetParamSimple(map, prefix + "ThroughputPerformance", this.ThroughputPerformance);
            this.SetParamSimple(map, prefix + "BurstPerformance", this.BurstPerformance);
        }
    }
}

