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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogFilter : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件名称。
        /// 
        /// 如：sql - SQL命令详情
        /// 
        /// host – 客户端 IP；
        /// user – 数据库账户；
        /// dbName – 数据库名称；
        /// sqlType - SQL类型；
        /// errCode - 错误码
        /// 
        /// execTime - 执行时间
        /// lockWaitTime - 锁等待时间
        /// ioWaitTime - IO等待时间
        /// trxLivingTime - 事务执行时间
        /// cpuTime- Cpu时间
        /// 
        /// threadId - 线程ID
        /// trxId - 事务ID
        /// checkRows - 扫描行数
        /// affectRows - 影响行数
        /// sentRows - 返回行数
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 过滤条件匹配类型。支持：
        /// INC – 包含；     （多个值之前是||的关系）
        /// EXC – 不包含； （多个值之前是&&的关系）
        /// EQS – 等于；     （多个值之前是||的关系）
        /// NEQ – 不等于；（多个值之前是&&的关系）
        /// 
        /// RA – 范围；
        /// </summary>
        [JsonProperty("Compare")]
        public string Compare{ get; set; }

        /// <summary>
        /// 过滤条件匹配值。当Compare=RG时，例：["1-100","200-300"]
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

