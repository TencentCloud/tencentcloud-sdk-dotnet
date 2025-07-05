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

namespace TencentCloud.Tcm.V20210413.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccessLogConfig : AbstractModel
    {
        
        /// <summary>
        /// 是否启用
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// 采用的模板，可选值：istio（默认）、trace
        /// </summary>
        [JsonProperty("Template")]
        public string Template{ get; set; }

        /// <summary>
        /// 选中的范围
        /// </summary>
        [JsonProperty("SelectedRange")]
        public SelectedRange SelectedRange{ get; set; }

        /// <summary>
        /// 腾讯云日志服务相关参数
        /// </summary>
        [JsonProperty("CLS")]
        public CLS CLS{ get; set; }

        /// <summary>
        /// 编码格式，可选值：TEXT、JSON
        /// </summary>
        [JsonProperty("Encoding")]
        public string Encoding{ get; set; }

        /// <summary>
        /// 日志格式
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// GRPC第三方服务器地址
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 是否启用GRPC第三方服务器
        /// </summary>
        [JsonProperty("EnableServer")]
        public bool? EnableServer{ get; set; }

        /// <summary>
        /// 是否启用标准输出
        /// </summary>
        [JsonProperty("EnableStdout")]
        public bool? EnableStdout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "Template", this.Template);
            this.SetParamObj(map, prefix + "SelectedRange.", this.SelectedRange);
            this.SetParamObj(map, prefix + "CLS.", this.CLS);
            this.SetParamSimple(map, prefix + "Encoding", this.Encoding);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "EnableServer", this.EnableServer);
            this.SetParamSimple(map, prefix + "EnableStdout", this.EnableStdout);
        }
    }
}

