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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceAuditLogFilters : AbstractModel
    {
        
        /// <summary>
        /// 过滤项。目前支持以下搜索条件：
        /// 
        /// 分词搜索：
        /// sql - SQL语句；
        /// 
        /// 等于、不等于、包含、不包含：
        /// host - 客户端地址；
        /// user - 用户名；
        /// dbName - 数据库名称；
        /// 
        /// 等于、不等于：
        /// sqlType - SQL类型；
        /// errCode - 错误码；
        /// threadId - 线程ID；
        /// 
        /// 范围搜索（时间类型统一为微妙）：
        /// execTime - 执行时间；
        /// lockWaitTime - 执行时间；
        /// ioWaitTime - IO等待时间；
        /// trxLivingTime - 事物持续时间；
        /// cpuTime - cpu时间；
        /// checkRows - 扫描行数；
        /// affectRows - 影响行数；
        /// sentRows - 返回行数。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 过滤条件。支持以下条件：
        /// INC - 包含,
        /// EXC - 不包含,
        /// EQS - 等于,
        /// NEQ - 不等于,
        /// RA - 范围。
        /// </summary>
        [JsonProperty("Compare")]
        public string Compare{ get; set; }

        /// <summary>
        /// 过滤的值。
        /// </summary>
        [JsonProperty("Value")]
        public string[] Value{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Compare", this.Compare);
            this.SetParamArraySimple(map, prefix + "Value.", this.Value);
        }
    }
}

