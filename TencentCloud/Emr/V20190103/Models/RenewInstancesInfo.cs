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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RenewInstancesInfo : AbstractModel
    {
        
        /// <summary>
        /// 节点资源ID
        /// </summary>
        [JsonProperty("EmrResourceId")]
        public string EmrResourceId{ get; set; }

        /// <summary>
        /// 节点类型。0:common节点；1:master节点
        /// ；2:core节点；3:task节点
        /// </summary>
        [JsonProperty("Flag")]
        public long? Flag{ get; set; }

        /// <summary>
        /// 内网IP
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 节点内存描述
        /// </summary>
        [JsonProperty("MemDesc")]
        public string MemDesc{ get; set; }

        /// <summary>
        /// 节点核数
        /// </summary>
        [JsonProperty("CpuNum")]
        public long? CpuNum{ get; set; }

        /// <summary>
        /// 硬盘大小
        /// </summary>
        [JsonProperty("DiskSize")]
        public string DiskSize{ get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 节点规格
        /// </summary>
        [JsonProperty("Spec")]
        public string Spec{ get; set; }

        /// <summary>
        /// 磁盘类型
        /// </summary>
        [JsonProperty("StorageType")]
        public long? StorageType{ get; set; }

        /// <summary>
        /// 系统盘大小
        /// </summary>
        [JsonProperty("RootSize")]
        public long? RootSize{ get; set; }

        /// <summary>
        /// 系统盘类型
        /// </summary>
        [JsonProperty("RootStorageType")]
        public long? RootStorageType{ get; set; }

        /// <summary>
        /// 数据盘信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MCMultiDisk")]
        public MultiDiskMC[] MCMultiDisk{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EmrResourceId", this.EmrResourceId);
            this.SetParamSimple(map, prefix + "Flag", this.Flag);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "MemDesc", this.MemDesc);
            this.SetParamSimple(map, prefix + "CpuNum", this.CpuNum);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "Spec", this.Spec);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "RootSize", this.RootSize);
            this.SetParamSimple(map, prefix + "RootStorageType", this.RootStorageType);
            this.SetParamArrayObj(map, prefix + "MCMultiDisk.", this.MCMultiDisk);
        }
    }
}

