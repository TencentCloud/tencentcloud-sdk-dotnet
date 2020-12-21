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

    public class ScdnLogTaskDetail : AbstractModel
    {
        
        /// <summary>
        /// scdn域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 防护类型
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 查询任务开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 查询任务结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 任务创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 日志包下载链接
        /// 成功返回下载链接，其他情况返回'-'
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DownloadUrl")]
        public string DownloadUrl{ get; set; }

        /// <summary>
        /// 任务状态
        /// created->任务已经创建
        /// processing->任务正在执行
        /// done->任务执行成功
        /// failed->任务执行失败
        /// no-log->没有日志产生
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 日志任务唯一id
        /// </summary>
        [JsonProperty("TaskID")]
        public string TaskID{ get; set; }

        /// <summary>
        /// 攻击类型, 可以为"all"
        /// AttackType映射如下:
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
        ///   file_upload = "文件上传攻击"
        ///   trojan_horse = "木马后门攻击"
        ///   csrf = "CSRF攻击"
        ///   custom_policy = "自定义策略"
        ///   ai_engine= 'AI引擎检出'
        ///   malicious_file_upload= '恶意文件上传'
        /// </summary>
        [JsonProperty("AttackType")]
        public string AttackType{ get; set; }

        /// <summary>
        /// 防御模式,可以为"all"
        /// DefenceMode映射如下：
        ///   observe = '观察模式'
        ///   intercept = '防御模式'
        /// </summary>
        [JsonProperty("DefenceMode")]
        public string DefenceMode{ get; set; }

        /// <summary>
        /// 查询条件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Conditions")]
        public ScdnEventLogConditions[] Conditions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DownloadUrl", this.DownloadUrl);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TaskID", this.TaskID);
            this.SetParamSimple(map, prefix + "AttackType", this.AttackType);
            this.SetParamSimple(map, prefix + "DefenceMode", this.DefenceMode);
            this.SetParamArrayObj(map, prefix + "Conditions.", this.Conditions);
        }
    }
}

