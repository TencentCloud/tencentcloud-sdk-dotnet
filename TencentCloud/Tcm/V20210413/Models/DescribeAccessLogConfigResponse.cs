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

namespace TencentCloud.Tcm.V20210413.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAccessLogConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// 访问日志输出路径。默认 /dev/stdout
        /// </summary>
        [JsonProperty("File")]
        public string File{ get; set; }

        /// <summary>
        /// 访问日志的格式。
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// 访问日志输出编码，可取值为 "TEXT" 或 "JSON"，默认 TEXT"
        /// </summary>
        [JsonProperty("Encoding")]
        public string Encoding{ get; set; }

        /// <summary>
        /// 选中的范围
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SelectedRange")]
        public SelectedRange SelectedRange{ get; set; }

        /// <summary>
        /// 采用的模板，可取值为"istio" 或 "trace"，默认为"istio"
        /// </summary>
        [JsonProperty("Template")]
        public string Template{ get; set; }

        /// <summary>
        /// 腾讯云日志服务相关参数
        /// </summary>
        [JsonProperty("CLS")]
        public CLS CLS{ get; set; }

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
        /// 是否启用访问日志采集
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "File", this.File);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "Encoding", this.Encoding);
            this.SetParamObj(map, prefix + "SelectedRange.", this.SelectedRange);
            this.SetParamSimple(map, prefix + "Template", this.Template);
            this.SetParamObj(map, prefix + "CLS.", this.CLS);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "EnableServer", this.EnableServer);
            this.SetParamSimple(map, prefix + "EnableStdout", this.EnableStdout);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

