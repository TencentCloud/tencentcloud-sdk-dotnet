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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLogsRequest : AbstractModel
    {
        
        /// <summary>
        /// 日志类型标识
        /// 流量日志：互联网边界防火墙netflow_border，NAT边界防火墙netflow_nat，VPC间防火墙vpcnetflow，内网流量日志netflow_fl，流量分析日志netflow_nta
        /// 入侵防御日志rule_threatinfo
        /// 访问控制日志：互联网边界规则rule_acl，NAT边界规则rule_acl，内网间规则rule_vpcacl，企业安全组rule_sg
        /// 操作日志：防火墙开关-开关操作operate_switch，防火墙开关-实例配置operate_instance，资产中心操作operate_assetgroup，访问控制操作operate_acl，零信任防护操作operate_identity，入侵防御操作-入侵防御operate_ids，入侵防御操作-安全基线operate_baseline，常用工具操作operate_tool，网络蜜罐操作operate_honeypot，日志投递操作operate_logdelivery，通用设置操作operate_logstorage，登录日志operate_login
        /// </summary>
        [JsonProperty("Index")]
        public string Index{ get; set; }

        /// <summary>
        /// 每页条数，最大支持2000
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 偏移值，最大支持60000
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 筛选开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 筛选结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 过滤条件组合，各数组元素间为AND关系，查询字段名Name参考文档https://cloud.tencent.com/document/product/1132/87894，数值类型字段不支持模糊匹配
        /// </summary>
        [JsonProperty("Filters")]
        public CommonFilter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Index", this.Index);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

