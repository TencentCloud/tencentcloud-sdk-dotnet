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

    public class DescribeSkillScanAlertListRequest : AbstractModel
    {
        
        /// <summary>
        /// 分页偏移量
        /// 取值范围：[0, +∞)
        /// 默认值：0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 每页返回数量
        /// 取值范围：[1, 200]
        /// 默认值：10
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 过滤条件列表，支持的过滤字段：BelongAssetType（归属资产类型 HOST/CONTAINER，未指定默认 HOST）、ContainerId（容器 ID，仅容器告警生效）、RiskLevel（风险等级，精确匹配）、Status（处理状态，精确匹配）、SkillName（Skill 名称，模糊匹配）、UUID（主机 UUID，精确匹配）、Level（告警级别，精确匹配）、ContentHash（文件 SHA256，精确匹配）、InstanceID（实例 ID，精确匹配）、InstanceName（实例名称，模糊匹配）、SkillPath（Skill 路径，模糊匹配）
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// 排序方式
        /// 枚举值：
        /// ASC：升序
        /// DESC：降序
        /// 默认值：DESC
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 排序字段
        /// 枚举值：
        /// CreateTime：首次检出时间
        /// SecurityScore：安全评分
        /// UpdateTime：更新时间
        /// 默认值：CreateTime
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }

        /// <summary>
        /// 集团账号的成员 id
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

