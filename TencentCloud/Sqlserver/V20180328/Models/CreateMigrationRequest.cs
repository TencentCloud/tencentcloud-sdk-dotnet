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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMigrationRequest : AbstractModel
    {
        
        /// <summary>
        /// 迁移任务的名称
        /// </summary>
        [JsonProperty("MigrateName")]
        public string MigrateName{ get; set; }

        /// <summary>
        /// 迁移类型（1:结构迁移 2:数据迁移 3:增量同步）
        /// </summary>
        [JsonProperty("MigrateType")]
        public ulong? MigrateType{ get; set; }

        /// <summary>
        /// 迁移源的类型 1:CDB for SQLServer 2:云服务器自建SQLServer数据库 4:SQLServer备份还原 5:SQLServer备份还原（COS方式）
        /// </summary>
        [JsonProperty("SourceType")]
        public ulong? SourceType{ get; set; }

        /// <summary>
        /// 迁移源
        /// </summary>
        [JsonProperty("Source")]
        public MigrateSource Source{ get; set; }

        /// <summary>
        /// 迁移目标
        /// </summary>
        [JsonProperty("Target")]
        public MigrateTarget Target{ get; set; }

        /// <summary>
        /// 迁移DB对象 ，离线迁移不使用（SourceType=4或SourceType=5）。
        /// </summary>
        [JsonProperty("MigrateDBSet")]
        public MigrateDB[] MigrateDBSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MigrateName", this.MigrateName);
            this.SetParamSimple(map, prefix + "MigrateType", this.MigrateType);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamObj(map, prefix + "Source.", this.Source);
            this.SetParamObj(map, prefix + "Target.", this.Target);
            this.SetParamArrayObj(map, prefix + "MigrateDBSet.", this.MigrateDBSet);
        }
    }
}

