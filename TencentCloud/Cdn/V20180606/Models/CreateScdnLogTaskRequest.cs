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

    public class CreateScdnLogTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 防护类型
        /// Mode 映射如下：
        ///   waf = "Web攻击"
        ///   cc = "CC攻击"
        ///   bot = "Bot攻击"
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

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
        /// 指定域名查询, 不填默认查询全部域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 指定攻击类型, 不填默认查询全部攻击类型
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
        ///   js = "JS主动探测"
        ///   cookie = "Cookie指纹"
        /// </summary>
        [JsonProperty("AttackType")]
        public string AttackType{ get; set; }

        /// <summary>
        /// 指定执行动作, 不填默认查询全部执行动作
        /// DefenceMode 映射如下：
        ///   observe = '观察模式'
        ///   intercept = '拦截模式'
        ///   captcha = "验证码"
        ///   redirect = "重定向"
        /// </summary>
        [JsonProperty("DefenceMode")]
        public string DefenceMode{ get; set; }

        /// <summary>
        /// 不填为全部ip
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 指定域名查询, 与 Domain 参数同时有值时使用 Domains 参数，不填默认查询全部域名，指定域名查询时最多支持同时选择 5 个域名查询
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "AttackType", this.AttackType);
            this.SetParamSimple(map, prefix + "DefenceMode", this.DefenceMode);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
        }
    }
}

