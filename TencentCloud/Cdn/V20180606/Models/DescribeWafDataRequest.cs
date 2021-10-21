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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeWafDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询起始时间，如：2018-09-04 10:40:00，返回结果大于等于指定时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 查询结束时间，如：2018-09-04 10:40:00，返回结果小于等于指定时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 时间粒度，支持以下几种模式：
        /// min：1 分钟粒度，指定查询区间 24 小时内（含 24 小时），可返回 1 分钟粒度明细数据
        /// 5min：5 分钟粒度，指定查询区间 31 天内（含 31 天），可返回 5 分钟粒度明细数据
        /// hour：1 小时粒度，指定查询区间 31 天内（含 31 天），可返回 1 小时粒度明细数据
        /// day：天粒度，指定查询区间大于 31 天，可返回天粒度明细数据
        /// 
        /// 仅支持30天内数据查询，且查询时间范围在 7 到 30 天最小粒度是 hour。
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// 指定域名查询
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 指定攻击类型
        /// 不填则查询所有攻击类型的数据分布
        /// AttackType 映射如下:
        /// "webshell" : Webshell检测防护
        /// "oa" : 常见OA漏洞防护
        /// "xss" : XSS跨站脚本攻击防护
        /// "xxe" : XXE攻击防护
        /// "webscan" : 扫描器攻击漏洞防护
        /// "cms" : 常见CMS漏洞防护
        /// "upload" : 恶意文件上传攻击防护
        /// "sql" : SQL注入攻击防护
        /// "cmd_inject": 命令/代码注入攻击防护
        /// "osc" : 开源组件漏洞防护
        /// "file_read" : 任意文件读取
        /// "ldap" : LDAP注入攻击防护
        /// "other" : 其它漏洞防护
        /// </summary>
        [JsonProperty("AttackType")]
        public string AttackType{ get; set; }

        /// <summary>
        /// 指定防御模式
        /// 不填则查询所有防御模式的数据总和
        /// DefenceMode映射如下：
        ///   observe = '观察模式'
        ///   intercept = '拦截模式'
        /// </summary>
        [JsonProperty("DefenceMode")]
        public string DefenceMode{ get; set; }

        /// <summary>
        /// 地域：mainland 或 overseas
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 指定多个攻击类型，取值参考AttackType
        /// </summary>
        [JsonProperty("AttackTypes")]
        public string[] AttackTypes{ get; set; }

        /// <summary>
        /// 指定域名列表查询
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "AttackType", this.AttackType);
            this.SetParamSimple(map, prefix + "DefenceMode", this.DefenceMode);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamArraySimple(map, prefix + "AttackTypes.", this.AttackTypes);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
        }
    }
}

