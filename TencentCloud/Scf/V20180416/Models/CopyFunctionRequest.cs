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

    public class CopyFunctionRequest : AbstractModel
    {
        
        /// <summary>
        /// 要复制的函数的名称
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// 新函数的名称
        /// </summary>
        [JsonProperty("NewFunctionName")]
        public string NewFunctionName{ get; set; }

        /// <summary>
        /// 要复制的函数所在的命名空间，默认为default
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 将函数复制到的命名空间，默认为default
        /// </summary>
        [JsonProperty("TargetNamespace")]
        public string TargetNamespace{ get; set; }

        /// <summary>
        /// 新函数的描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 要将函数复制到的地域，不填则默认为当前地域
        /// </summary>
        [JsonProperty("TargetRegion")]
        public string TargetRegion{ get; set; }

        /// <summary>
        /// 如果目标Namespace下已有同名函数，是否覆盖，默认为否
        /// （注意：如果选择覆盖，会导致同名函数被删除，请慎重操作）
        /// TRUE：覆盖同名函数
        /// FALSE：不覆盖同名函数
        /// </summary>
        [JsonProperty("Override")]
        public bool? Override{ get; set; }

        /// <summary>
        /// 是否复制函数的属性，包括环境变量、内存、超时、函数描述、标签、VPC等，默认为是。
        /// TRUE：复制函数配置
        /// FALSE：不复制函数配置
        /// </summary>
        [JsonProperty("CopyConfiguration")]
        public bool? CopyConfiguration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "NewFunctionName", this.NewFunctionName);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "TargetNamespace", this.TargetNamespace);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "TargetRegion", this.TargetRegion);
            this.SetParamSimple(map, prefix + "Override", this.Override);
            this.SetParamSimple(map, prefix + "CopyConfiguration", this.CopyConfiguration);
        }
    }
}

