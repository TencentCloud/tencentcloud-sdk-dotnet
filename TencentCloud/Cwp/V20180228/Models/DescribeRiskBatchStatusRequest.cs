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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRiskBatchStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 操作事件类型，文件查杀：MALWARE，异常登录：HOST_LOGIN，密码破解：BRUTE_ATTACK，恶意请求：MALICIOUS_REQUEST，高危命令：BASH_EVENT，本地提权：PRIVILEGE_EVENT，反弹shell：REVERSE_SHELL
        /// </summary>
        [JsonProperty("RiskType")]
        public string RiskType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RiskType", this.RiskType);
        }
    }
}

