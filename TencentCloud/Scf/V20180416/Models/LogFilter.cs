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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogFilter : AbstractModel
    {
        
        /// <summary>
        /// filter.RetCode的取值有：
        /// not0 表示只返回错误日志，
        /// is0 表示只返回正确日志，
        /// TimeLimitExceeded 返回函数调用发生超时的日志，
        /// ResourceLimitExceeded 返回函数调用发生资源超限的日志，
        /// UserCodeException 返回函数调用发生用户代码错误的日志，
        /// 无输入则返回所有日志。
        /// </summary>
        [JsonProperty("RetCode")]
        public string RetCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RetCode", this.RetCode);
        }
    }
}

