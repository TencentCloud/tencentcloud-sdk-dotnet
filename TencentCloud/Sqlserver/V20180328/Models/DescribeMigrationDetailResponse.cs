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

    public class DescribeMigrationDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 迁移任务ID
        /// </summary>
        [JsonProperty("MigrateId")]
        public ulong? MigrateId{ get; set; }

        /// <summary>
        /// 迁移任务名称
        /// </summary>
        [JsonProperty("MigrateName")]
        public string MigrateName{ get; set; }

        /// <summary>
        /// 迁移任务所属的用户ID
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 迁移任务所属的地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 迁移源的类型 1:CDB for SQLServer 2:云服务器自建SQLServer数据库 4:SQLServer备份还原 5:SQLServer备份还原（COS方式）
        /// </summary>
        [JsonProperty("SourceType")]
        public long? SourceType{ get; set; }

        /// <summary>
        /// 迁移任务的创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 迁移任务的开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 迁移任务的结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 迁移任务的状态（1:初始化,4:迁移中,5.迁移失败,6.迁移成功）
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 迁移任务当前进度
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }

        /// <summary>
        /// 迁移类型（1:结构迁移 2:数据迁移 3:增量同步）
        /// </summary>
        [JsonProperty("MigrateType")]
        public long? MigrateType{ get; set; }

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
        /// 迁移DB对象 ，离线迁移（SourceType=4或SourceType=5）不使用。
        /// </summary>
        [JsonProperty("MigrateDBSet")]
        public MigrateDB[] MigrateDBSet{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MigrateId", this.MigrateId);
            this.SetParamSimple(map, prefix + "MigrateName", this.MigrateName);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "MigrateType", this.MigrateType);
            this.SetParamObj(map, prefix + "Source.", this.Source);
            this.SetParamObj(map, prefix + "Target.", this.Target);
            this.SetParamArrayObj(map, prefix + "MigrateDBSet.", this.MigrateDBSet);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

