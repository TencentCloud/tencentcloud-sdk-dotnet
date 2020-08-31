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

    public class DescribeScdnTopDataRequest : AbstractModel
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
        /// 查询的SCDN TOP攻击数据类型：
        /// waf：Web 攻击防护TOP数据
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 排序对象，支持以下几种形式：
        /// url：攻击目标 url 排序
        /// ip：攻击源 IP 排序
        /// attackType：攻击类型排序
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// 排序使用的指标名称：
        /// request：请求次数
        /// </summary>
        [JsonProperty("Filter")]
        public string Filter{ get; set; }

        /// <summary>
        /// 指定域名查询
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 指定攻击类型, 仅 Mode=waf 时有效
        /// 不填则查询所有攻击类型的数据总和
        /// AttackType 映射如下:
        ///   other = '未知类型'
        ///   malicious_scan = "恶意扫描"
        ///   sql_inject = "SQL注入攻击"
        ///   xss = "XSS攻击"
        ///   cmd_inject = "命令注入攻击"
        ///   ldap_inject = "LDAP注入攻击"
        ///   ssi_inject = "SSI注入攻击"
        ///   xml_inject = "XML注入攻击"
        ///   web_service = "WEB服务漏洞攻击"
        ///   web_app = "WEB应用漏洞攻击"
        ///   path_traversal = "路径跨越攻击"
        ///   illegal_access_core_file = "核心文件非法访问"
        ///   trojan_horse = "木马后门攻击"
        ///   csrf = "CSRF攻击"
        ///   malicious_file_upload= '恶意文件上传'
        /// </summary>
        [JsonProperty("AttackType")]
        public string AttackType{ get; set; }

        /// <summary>
        /// 指定防御模式,仅 Mode=waf 时有效
        /// 不填则查询所有防御模式的数据总和
        /// DefenceMode 映射如下：
        ///   observe = '观察模式'
        ///   intercept = '拦截模式'
        /// </summary>
        [JsonProperty("DefenceMode")]
        public string DefenceMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamSimple(map, prefix + "Filter", this.Filter);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "AttackType", this.AttackType);
            this.SetParamSimple(map, prefix + "DefenceMode", this.DefenceMode);
        }
    }
}

