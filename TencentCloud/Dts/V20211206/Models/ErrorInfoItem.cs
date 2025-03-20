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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ErrorInfoItem : AbstractModel
    {
        
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// 解决方案
        /// </summary>
        [JsonProperty("Solution")]
        public string Solution{ get; set; }

        /// <summary>
        /// 错误日志信息
        /// </summary>
        [JsonProperty("ErrorLog")]
        public string ErrorLog{ get; set; }

        /// <summary>
        /// 文档提示
        /// </summary>
        [JsonProperty("HelpDoc")]
        public string HelpDoc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Solution", this.Solution);
            this.SetParamSimple(map, prefix + "ErrorLog", this.ErrorLog);
            this.SetParamSimple(map, prefix + "HelpDoc", this.HelpDoc);
        }
    }
}

