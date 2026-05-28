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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RollbackPGUserMigrationsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>云开发环境ID</p>
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// <p>要回滚的条数</p><p>按照逆序回滚最近N条migration</p>
        /// </summary>
        [JsonProperty("LastN")]
        public long? LastN{ get; set; }

        /// <summary>
        /// <p>等待获取数据库锁的最长时间</p><p>单位：毫秒</p><p>默认值：5000</p>
        /// </summary>
        [JsonProperty("LockTimeoutMs")]
        public long? LockTimeoutMs{ get; set; }

        /// <summary>
        /// <p>单条 SQL 执行最长时间，超过后由 PostgreSQL 取消该语句</p><p>单位：毫秒</p><p>默认值：300000</p>
        /// </summary>
        [JsonProperty("StatementTimeoutMs")]
        public long? StatementTimeoutMs{ get; set; }

        /// <summary>
        /// <p>标记API调用来源</p>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "LastN", this.LastN);
            this.SetParamSimple(map, prefix + "LockTimeoutMs", this.LockTimeoutMs);
            this.SetParamSimple(map, prefix + "StatementTimeoutMs", this.StatementTimeoutMs);
            this.SetParamSimple(map, prefix + "Source", this.Source);
        }
    }
}

