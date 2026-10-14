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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuditLogQueryFilter : AbstractModel
    {
        
        /// <summary>
        /// <p>SQL 类型列表，取值如 SELECT、INSERT、UPDATE、DELETE 等。</p>
        /// </summary>
        [JsonProperty("SqlType")]
        public string[] SqlType{ get; set; }

        /// <summary>
        /// <p>执行耗时范围（毫秒），长度为 2 的数组：[最小值, 最大值]。</p>
        /// </summary>
        [JsonProperty("ExecTime")]
        public long?[] ExecTime{ get; set; }

        /// <summary>
        /// <p>IO 等待耗时范围（毫秒），长度为 2 的数组。</p>
        /// </summary>
        [JsonProperty("IoWaitTime")]
        public long?[] IoWaitTime{ get; set; }

        /// <summary>
        /// <p>CPU 耗时范围（毫秒），长度为 2 的数组。</p>
        /// </summary>
        [JsonProperty("CpuTime")]
        public long?[] CpuTime{ get; set; }

        /// <summary>
        /// <p>锁等待耗时范围（毫秒），长度为 2 的数组。</p>
        /// </summary>
        [JsonProperty("LockWaitTime")]
        public long?[] LockWaitTime{ get; set; }

        /// <summary>
        /// <p>SQL 执行错误码，例如 0 表示成功。</p>
        /// </summary>
        [JsonProperty("ErrCode")]
        public string ErrCode{ get; set; }

        /// <summary>
        /// <p>错误信息。</p>
        /// </summary>
        [JsonProperty("ErrInfo")]
        public string ErrInfo{ get; set; }

        /// <summary>
        /// <p>数据库名列表。</p>
        /// </summary>
        [JsonProperty("DBName")]
        public string[] DBName{ get; set; }

        /// <summary>
        /// <p>用户名列表。</p>
        /// </summary>
        [JsonProperty("User")]
        public string[] User{ get; set; }

        /// <summary>
        /// <p>来源 IP 列表。</p>
        /// </summary>
        [JsonProperty("Host")]
        public string[] Host{ get; set; }

        /// <summary>
        /// <p>线程 ID 列表。</p>
        /// </summary>
        [JsonProperty("ThreadId")]
        public string[] ThreadId{ get; set; }

        /// <summary>
        /// <p>代理节点 Host 列表。</p>
        /// </summary>
        [JsonProperty("ProxyHostList")]
        public string[] ProxyHostList{ get; set; }

        /// <summary>
        /// <p>后端 Set Host 列表。</p>
        /// </summary>
        [JsonProperty("SetHostList")]
        public string[] SetHostList{ get; set; }

        /// <summary>
        /// <p>后端 Set ID 列表。</p>
        /// </summary>
        [JsonProperty("SetIdList")]
        public string[] SetIdList{ get; set; }

        /// <summary>
        /// <p>多 SQL 关键词条件，JSON 字符串，内部为二维数组：第一级为 AND，第二级为 OR。注意云 API 平台不支持二维数组，此处用字符串承载，服务端自动解析。</p>
        /// </summary>
        [JsonProperty("MultiSql")]
        public string MultiSql{ get; set; }

        /// <summary>
        /// <p>排除的多 SQL 关键词条件，JSON 字符串，结构同 MultiSql。</p>
        /// </summary>
        [JsonProperty("ExcludeMultiSql")]
        public string ExcludeMultiSql{ get; set; }

        /// <summary>
        /// <p>SQL 模板 ID。</p>
        /// </summary>
        [JsonProperty("SqlTemplateId")]
        public string SqlTemplateId{ get; set; }

        /// <summary>
        /// <p>SQL 开始时间，示例：2026-10-10 11:05:06.002211</p><p>参数格式：YYYY-MM-DD hh:mm:ss.SSSSSS</p>
        /// </summary>
        [JsonProperty("SqlStartTime")]
        public string SqlStartTime{ get; set; }

        /// <summary>
        /// <p>查询 ID，关联查询时使用（LogType=All 时必填）。</p>
        /// </summary>
        [JsonProperty("QueryId")]
        public string QueryId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SqlType.", this.SqlType);
            this.SetParamArraySimple(map, prefix + "ExecTime.", this.ExecTime);
            this.SetParamArraySimple(map, prefix + "IoWaitTime.", this.IoWaitTime);
            this.SetParamArraySimple(map, prefix + "CpuTime.", this.CpuTime);
            this.SetParamArraySimple(map, prefix + "LockWaitTime.", this.LockWaitTime);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "ErrInfo", this.ErrInfo);
            this.SetParamArraySimple(map, prefix + "DBName.", this.DBName);
            this.SetParamArraySimple(map, prefix + "User.", this.User);
            this.SetParamArraySimple(map, prefix + "Host.", this.Host);
            this.SetParamArraySimple(map, prefix + "ThreadId.", this.ThreadId);
            this.SetParamArraySimple(map, prefix + "ProxyHostList.", this.ProxyHostList);
            this.SetParamArraySimple(map, prefix + "SetHostList.", this.SetHostList);
            this.SetParamArraySimple(map, prefix + "SetIdList.", this.SetIdList);
            this.SetParamSimple(map, prefix + "MultiSql", this.MultiSql);
            this.SetParamSimple(map, prefix + "ExcludeMultiSql", this.ExcludeMultiSql);
            this.SetParamSimple(map, prefix + "SqlTemplateId", this.SqlTemplateId);
            this.SetParamSimple(map, prefix + "SqlStartTime", this.SqlStartTime);
            this.SetParamSimple(map, prefix + "QueryId", this.QueryId);
        }
    }
}

