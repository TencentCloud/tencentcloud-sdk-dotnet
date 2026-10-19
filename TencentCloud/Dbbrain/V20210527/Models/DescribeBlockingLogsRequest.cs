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

    public class DescribeBlockingLogsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>服务产品类型，固定为sqlserver。</p>
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// <p>查询起始时间（服务端时区 UTC+8），格式：yyyy-MM-dd HH:mm:ss。必须在最近 30 天内，否则返回 InvalidParameterValue。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>查询结束时间（服务端时区 UTC+8），格式：yyyy-MM-dd HH:mm:ss，需大于 StartTime。单次查询跨度必须 ≤ 1 天（24 小时），否则返回 InvalidParameterValue。大跨度趋势场景请改用 DescribeBlockingTrend。</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>根因过滤（可选），支持：C1_LONG_QUERY=长事务查询持锁；C2_SLEEP_UNCOMMITTED=sleeping会话持未提交事务；C3_LOCK_ESCALATION=锁升级；C4_HIGH_CONCURRENCY=高并发争用；C5_INDEX_MISS=索引缺失导致大范围锁；C6_ORPHAN_TRAN=孤儿事务。</p>
        /// </summary>
        [JsonProperty("RootCause")]
        public string RootCause{ get; set; }

        /// <summary>
        /// <p>头SQL（blocker）MD5过滤（可选）。</p>
        /// </summary>
        [JsonProperty("BlockingSqlMd5")]
        public string BlockingSqlMd5{ get; set; }

        /// <summary>
        /// <p>被阻塞SQL（blocked）MD5过滤（可选）。</p>
        /// </summary>
        [JsonProperty("BlockedSqlMd5")]
        public string BlockedSqlMd5{ get; set; }

        /// <summary>
        /// <p>数据库名列表过滤（可选），按阻塞事件所在数据库名过滤；列表内任意匹配即命中，最多50项。多库实例场景下推荐用本字段定位阻塞所在库。</p>
        /// </summary>
        [JsonProperty("DatabaseNames")]
        public string[] DatabaseNames{ get; set; }

        /// <summary>
        /// <p>头阻塞会话 ID（SPID）列表过滤（可选），列表内任意匹配即命中，最多50项。</p>
        /// </summary>
        [JsonProperty("BlockingSessionIds")]
        public long?[] BlockingSessionIds{ get; set; }

        /// <summary>
        /// <p>被阻塞会话 ID（SPID）列表过滤（可选），列表内任意匹配即命中，最多50项。</p>
        /// </summary>
        [JsonProperty("BlockedSessionIds")]
        public long?[] BlockedSessionIds{ get; set; }

        /// <summary>
        /// <p>头阻塞登录名列表过滤（可选），列表内任意匹配即命中，最多50项。</p>
        /// </summary>
        [JsonProperty("BlockingLoginNames")]
        public string[] BlockingLoginNames{ get; set; }

        /// <summary>
        /// <p>被阻塞登录名列表过滤（可选），列表内任意匹配即命中，最多50项。</p>
        /// </summary>
        [JsonProperty("BlockedLoginNames")]
        public string[] BlockedLoginNames{ get; set; }

        /// <summary>
        /// <p>头阻塞客户端主机列表过滤（可选），列表内任意匹配即命中，最多50项。</p>
        /// </summary>
        [JsonProperty("BlockingHostNames")]
        public string[] BlockingHostNames{ get; set; }

        /// <summary>
        /// <p>被阻塞客户端主机列表过滤（可选），列表内任意匹配即命中，最多50项。</p>
        /// </summary>
        [JsonProperty("BlockedHostNames")]
        public string[] BlockedHostNames{ get; set; }

        /// <summary>
        /// <p>头阻塞客户端应用列表过滤（可选），列表内任意匹配即命中，最多50项。</p>
        /// </summary>
        [JsonProperty("BlockingClientApps")]
        public string[] BlockingClientApps{ get; set; }

        /// <summary>
        /// <p>被阻塞客户端应用列表过滤（可选），列表内任意匹配即命中，最多50项。</p>
        /// </summary>
        [JsonProperty("BlockedClientApps")]
        public string[] BlockedClientApps{ get; set; }

        /// <summary>
        /// <p>被阻塞方等待锁模式列表过滤（可选），SQL Server原生lock_mode枚举，常见取值（非穷尽）：S、U、X、IS、IU、IX、SIU、SIX、UIX、Sch-S、Sch-M；serializable隔离级别下还可能出现RangeS-S / RangeS-U / RangeX-X / RangeI-N系列。列表内任意匹配即命中，最多50项。</p>
        /// </summary>
        [JsonProperty("BlockedLockModes")]
        public string[] BlockedLockModes{ get; set; }

        /// <summary>
        /// <p>被阻塞方等待时长下限（毫秒，含），用于筛选慢阻塞（可选）。</p>
        /// </summary>
        [JsonProperty("DurationMsMin")]
        public long? DurationMsMin{ get; set; }

        /// <summary>
        /// <p>被阻塞方等待时长上限（毫秒，含），用于筛选阻塞时长不超过某值的记录（可选）。</p>
        /// </summary>
        [JsonProperty("DurationMsMax")]
        public long? DurationMsMax{ get; set; }

        /// <summary>
        /// <p>排序字段（可选），支持reportTime（按明细行上报时间，默认）/ durationMs（按链路阻塞时长）/ blockedWaitTimeMs（按被阻塞方等待时长）/ blockingWaitTimeMs（按头阻塞自身等待时长）。</p>
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// <p>排序方向（可选），支持desc（默认，倒序）/ asc（正序）。</p>
        /// </summary>
        [JsonProperty("OrderDirection")]
        public string OrderDirection{ get; set; }

        /// <summary>
        /// <p>返回条数上限，默认20，最大100。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>偏移量，默认 0。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>是否返回原始 blocked_process_report XML（可选，默认 false 不返回）。该字段体积较大（KB 级起步，含完整执行计划/等待链/死锁明细等原始上下文），常规列表展示不需要，仅在需要查看完整 XML 现场（如线下诊断、离线分析）时将本参数置为 true 按需拉取。</p>
        /// </summary>
        [JsonProperty("WithXml")]
        public bool? WithXml{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "RootCause", this.RootCause);
            this.SetParamSimple(map, prefix + "BlockingSqlMd5", this.BlockingSqlMd5);
            this.SetParamSimple(map, prefix + "BlockedSqlMd5", this.BlockedSqlMd5);
            this.SetParamArraySimple(map, prefix + "DatabaseNames.", this.DatabaseNames);
            this.SetParamArraySimple(map, prefix + "BlockingSessionIds.", this.BlockingSessionIds);
            this.SetParamArraySimple(map, prefix + "BlockedSessionIds.", this.BlockedSessionIds);
            this.SetParamArraySimple(map, prefix + "BlockingLoginNames.", this.BlockingLoginNames);
            this.SetParamArraySimple(map, prefix + "BlockedLoginNames.", this.BlockedLoginNames);
            this.SetParamArraySimple(map, prefix + "BlockingHostNames.", this.BlockingHostNames);
            this.SetParamArraySimple(map, prefix + "BlockedHostNames.", this.BlockedHostNames);
            this.SetParamArraySimple(map, prefix + "BlockingClientApps.", this.BlockingClientApps);
            this.SetParamArraySimple(map, prefix + "BlockedClientApps.", this.BlockedClientApps);
            this.SetParamArraySimple(map, prefix + "BlockedLockModes.", this.BlockedLockModes);
            this.SetParamSimple(map, prefix + "DurationMsMin", this.DurationMsMin);
            this.SetParamSimple(map, prefix + "DurationMsMax", this.DurationMsMax);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "WithXml", this.WithXml);
        }
    }
}

