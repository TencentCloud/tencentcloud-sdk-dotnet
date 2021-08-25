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

    public class ListTopWafDataRequest : AbstractModel
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
        /// 指定域名查询，不填写查询整个AppID下数据
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 指定攻击类型
        /// 不填则查询所有攻击类型的数据总和
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
        /// DefenceMode 映射如下：
        ///   observe = '观察模式'
        ///   intercept = '拦截模式'
        /// </summary>
        [JsonProperty("DefenceMode")]
        public string DefenceMode{ get; set; }

        /// <summary>
        /// 排序对象，支持以下几种形式：
        /// url：攻击目标 url 排序
        /// ip：攻击源 IP 排序
        /// attackType：攻击类型排序
        /// domain：当查询整个AppID下数据时，按照域名请求量排序
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// 地域：mainland 或 overseas
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 指定攻击类型列表，取值参考AttackType
        /// </summary>
        [JsonProperty("AttackTypes")]
        public string[] AttackTypes{ get; set; }

        /// <summary>
        /// 指定域名列表查询，不填写查询整个AppID下数据
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
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "AttackType", this.AttackType);
            this.SetParamSimple(map, prefix + "DefenceMode", this.DefenceMode);
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamArraySimple(map, prefix + "AttackTypes.", this.AttackTypes);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
        }
    }
}

