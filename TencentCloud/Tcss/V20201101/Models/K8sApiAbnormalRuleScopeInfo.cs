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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class K8sApiAbnormalRuleScopeInfo : AbstractModel
    {
        
        /// <summary>
        /// 范围
        /// 系统事件:
        /// ANONYMOUS_ACCESS: 匿名访问
        /// ABNORMAL_UA_REQ: 异常UA请求
        /// ANONYMOUS_ABNORMAL_PERMISSION: 匿名用户权限异动
        /// GET_CREDENTIALS: 凭据信息获取
        /// MOUNT_SENSITIVE_PATH: 敏感路径挂载
        /// COMMAND_RUN: 命令执行
        /// PRIVILEGE_CONTAINER: 特权容器
        /// EXCEPTION_CRONTAB_TASK: 异常定时任务
        /// STATICS_POD: 静态pod创建
        /// ABNORMAL_CREATE_POD: 异常pod创建
        /// USER_DEFINED: 用户自定义
        /// </summary>
        [JsonProperty("Scope")]
        public string Scope{ get; set; }

        /// <summary>
        /// 动作(RULE_MODE_ALERT: 告警 RULE_MODE_RELEASE:放行)
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 威胁等级 HIGH:高级 MIDDLE: 中级 LOW:低级 NOTICE:提示
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// 开关状态(true:开 false:关) 适用于系统规则
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// 是否被删除 适用于自定义规则入参
        /// </summary>
        [JsonProperty("IsDelete")]
        public bool? IsDelete{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IsDelete", this.IsDelete);
        }
    }
}

