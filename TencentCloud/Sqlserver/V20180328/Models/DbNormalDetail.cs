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

    public class DbNormalDetail : AbstractModel
    {
        
        /// <summary>
        /// 是否已订阅 0：否 1：是
        /// </summary>
        [JsonProperty("IsSubscribed")]
        public string IsSubscribed{ get; set; }

        /// <summary>
        /// 数据库排序规则
        /// </summary>
        [JsonProperty("CollationName")]
        public string CollationName{ get; set; }

        /// <summary>
        /// 开启CT之后是否自动清理 0：否 1：是
        /// </summary>
        [JsonProperty("IsAutoCleanupOn")]
        public string IsAutoCleanupOn{ get; set; }

        /// <summary>
        /// 是否已启用代理  0：否 1：是
        /// </summary>
        [JsonProperty("IsBrokerEnabled")]
        public string IsBrokerEnabled{ get; set; }

        /// <summary>
        /// 是否已开启/关闭CDC 0：关闭 1：开启
        /// </summary>
        [JsonProperty("IsCdcEnabled")]
        public string IsCdcEnabled{ get; set; }

        /// <summary>
        /// 是否已启用/ 禁用CT 0：禁用 1：启用
        /// </summary>
        [JsonProperty("IsDbChainingOn")]
        public string IsDbChainingOn{ get; set; }

        /// <summary>
        /// 是否加密 0：否 1：是
        /// </summary>
        [JsonProperty("IsEncrypted")]
        public string IsEncrypted{ get; set; }

        /// <summary>
        /// 是否全文启用 0：否 1：是
        /// </summary>
        [JsonProperty("IsFulltextEnabled")]
        public string IsFulltextEnabled{ get; set; }

        /// <summary>
        /// 是否是镜像 0：否 1：是
        /// </summary>
        [JsonProperty("IsMirroring")]
        public string IsMirroring{ get; set; }

        /// <summary>
        /// 是否已发布 0：否 1：是
        /// </summary>
        [JsonProperty("IsPublished")]
        public string IsPublished{ get; set; }

        /// <summary>
        /// 是否开启快照 0：否 1：是
        /// </summary>
        [JsonProperty("IsReadCommittedSnapshotOn")]
        public string IsReadCommittedSnapshotOn{ get; set; }

        /// <summary>
        /// 是否可信任 0：否 1：是
        /// </summary>
        [JsonProperty("IsTrustworthyOn")]
        public string IsTrustworthyOn{ get; set; }

        /// <summary>
        /// 镜像状态
        /// </summary>
        [JsonProperty("MirroringState")]
        public string MirroringState{ get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 恢复模式
        /// </summary>
        [JsonProperty("RecoveryModelDesc")]
        public string RecoveryModelDesc{ get; set; }

        /// <summary>
        /// 保留天数
        /// </summary>
        [JsonProperty("RetentionPeriod")]
        public string RetentionPeriod{ get; set; }

        /// <summary>
        /// 数据库状态
        /// </summary>
        [JsonProperty("StateDesc")]
        public string StateDesc{ get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        [JsonProperty("UserAccessDesc")]
        public string UserAccessDesc{ get; set; }

        /// <summary>
        /// 数据库创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsSubscribed", this.IsSubscribed);
            this.SetParamSimple(map, prefix + "CollationName", this.CollationName);
            this.SetParamSimple(map, prefix + "IsAutoCleanupOn", this.IsAutoCleanupOn);
            this.SetParamSimple(map, prefix + "IsBrokerEnabled", this.IsBrokerEnabled);
            this.SetParamSimple(map, prefix + "IsCdcEnabled", this.IsCdcEnabled);
            this.SetParamSimple(map, prefix + "IsDbChainingOn", this.IsDbChainingOn);
            this.SetParamSimple(map, prefix + "IsEncrypted", this.IsEncrypted);
            this.SetParamSimple(map, prefix + "IsFulltextEnabled", this.IsFulltextEnabled);
            this.SetParamSimple(map, prefix + "IsMirroring", this.IsMirroring);
            this.SetParamSimple(map, prefix + "IsPublished", this.IsPublished);
            this.SetParamSimple(map, prefix + "IsReadCommittedSnapshotOn", this.IsReadCommittedSnapshotOn);
            this.SetParamSimple(map, prefix + "IsTrustworthyOn", this.IsTrustworthyOn);
            this.SetParamSimple(map, prefix + "MirroringState", this.MirroringState);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "RecoveryModelDesc", this.RecoveryModelDesc);
            this.SetParamSimple(map, prefix + "RetentionPeriod", this.RetentionPeriod);
            this.SetParamSimple(map, prefix + "StateDesc", this.StateDesc);
            this.SetParamSimple(map, prefix + "UserAccessDesc", this.UserAccessDesc);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

