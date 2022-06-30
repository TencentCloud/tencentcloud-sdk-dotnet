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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LockComponentInfo : AbstractModel
    {
        
        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// 表名称
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 分区
        /// </summary>
        [JsonProperty("Partition")]
        public string Partition{ get; set; }

        /// <summary>
        /// 锁类型：SHARED_READ、SHARED_WRITE、EXCLUSIVE
        /// </summary>
        [JsonProperty("LockType")]
        public string LockType{ get; set; }

        /// <summary>
        /// 锁级别：DB、TABLE、PARTITION
        /// </summary>
        [JsonProperty("LockLevel")]
        public string LockLevel{ get; set; }

        /// <summary>
        /// 锁操作：SELECT,INSERT,UPDATE,DELETE,UNSET,NO_TXN
        /// </summary>
        [JsonProperty("DataOperationType")]
        public string DataOperationType{ get; set; }

        /// <summary>
        /// 是否保持Acid
        /// </summary>
        [JsonProperty("IsAcid")]
        public bool? IsAcid{ get; set; }

        /// <summary>
        /// 是否动态分区写
        /// </summary>
        [JsonProperty("IsDynamicPartitionWrite")]
        public bool? IsDynamicPartitionWrite{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "Partition", this.Partition);
            this.SetParamSimple(map, prefix + "LockType", this.LockType);
            this.SetParamSimple(map, prefix + "LockLevel", this.LockLevel);
            this.SetParamSimple(map, prefix + "DataOperationType", this.DataOperationType);
            this.SetParamSimple(map, prefix + "IsAcid", this.IsAcid);
            this.SetParamSimple(map, prefix + "IsDynamicPartitionWrite", this.IsDynamicPartitionWrite);
        }
    }
}

