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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeHostVulRiskEventListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>分页偏移量<br>取值范围：[0, +∞)<br>默认值：0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>每页返回数量<br>取值范围：[1, 100]<br>默认值：10</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>过滤条件支持的Filter.Name：VulName - 模糊匹配，按漏洞名称搜索Category - 精确匹配，按漏洞分类筛选：LINUX-Linux软件漏洞 WINDOWS-Windows系统补丁漏洞 WEB_CMS-Web-CMS漏洞 APPLICATION-应用漏洞 EMERGENCY-应急漏洞RiskStatus - 精确匹配，按风险状态筛选：PENDING-待处理 HANDLED-已处置 FIXED-已修复 SCANNING-重新检测中 IGNORED-已忽略 NOT_REQUIRED-无需处理 DELETED-已删除 FIXING-修复中 NEED_REBOOT-已修复待重启 FIX_FAILED-修复失败Level - 精确匹配，按漏洞危害等级筛选：UNKNOWN-无效 LOW-低危 MEDIUM-中危 HIGH-高危 CRITICAL-严重CVSSLevel - 精确匹配，兼容字段，等同于 LevelVPRLevel - 精确匹配，按VPR修复优先级筛选：DEFERRABLE-可暂缓修复 PLANNED-计划修复 SOON-尽快修复 URGENT-紧急修复- 精确匹配，按漏洞ID筛选InstanceID - 精确匹配，按云主机实例ID筛选InstanceId - 精确匹配，兼容字段，等同于 InstanceIDUUID - 精确匹配，按主机安全UUID筛选LatestScanTimeStart - 范围匹配，最近扫描时间起，格式：YYYY-MM-DD HH:mm:ssLatestScanTimeEnd - 范围匹配，最近扫描时间止，格式：YYYY-MM-DD HH:mm:ss</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// <p>排序方式<br>枚举值：<br>asc：升序<br>desc：降序<br>默认值：desc</p>
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// <p>排序字段<br>枚举值：<br>LatestScanTime：按最近扫描时间排序<br>Level：按威胁等级排序<br>VPRLevel：按 VPR 评级排序<br>RiskStatus：按风险状态排序<br>VulID：按漏洞 ID 排序<br>InstanceID：按实例 ID 排序<br>默认值：LatestScanTime</p>
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }

        /// <summary>
        /// 集团账号的成员id
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
        }
    }
}

