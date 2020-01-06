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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RollbackInstancesInfo : AbstractModel
    {
        
        /// <summary>
        /// 云数据库实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 回档策略。可选值为：table、db、full；默认值为full。table - 急速回档模式，仅导入所选中表级别的备份和binlog，如有跨表操作，且关联表未被同时选中，将会导致回档失败，该模式下参数Databases必须为空；db - 快速模式，仅导入所选中库级别的备份和binlog，如有跨库操作，且关联库未被同时选中，将会导致回档失败；full - 普通回档模式，将导入整个实例的备份和binlog，速度较慢。
        /// </summary>
        [JsonProperty("Strategy")]
        public string Strategy{ get; set; }

        /// <summary>
        /// 数据库回档时间，时间格式为：yyyy-mm-dd hh:mm:ss
        /// </summary>
        [JsonProperty("RollbackTime")]
        public string RollbackTime{ get; set; }

        /// <summary>
        /// 待回档的数据库信息，表示整库回档
        /// </summary>
        [JsonProperty("Databases")]
        public RollbackDBName[] Databases{ get; set; }

        /// <summary>
        /// 待回档的数据库表信息，表示按表回档
        /// </summary>
        [JsonProperty("Tables")]
        public RollbackTables[] Tables{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Strategy", this.Strategy);
            this.SetParamSimple(map, prefix + "RollbackTime", this.RollbackTime);
            this.SetParamArrayObj(map, prefix + "Databases.", this.Databases);
            this.SetParamArrayObj(map, prefix + "Tables.", this.Tables);
        }
    }
}

