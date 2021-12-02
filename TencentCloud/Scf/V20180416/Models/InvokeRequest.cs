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

    public class InvokeRequest : AbstractModel
    {
        
        /// <summary>
        /// 函数名称
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// 同步调用请使用[同步 Invoke 调用接口](https://cloud.tencent.com/document/product/583/58400) 或填写同步调用参数 RequestResponse ，建议使用同步调用接口以获取最佳性能；异步调用填写 Event；默认为同步。接口超时时间为 300s，更长超时时间请使用异步调用。
        /// </summary>
        [JsonProperty("InvocationType")]
        public string InvocationType{ get; set; }

        /// <summary>
        /// 触发函数的版本号或别名，默认值为 $LATEST
        /// </summary>
        [JsonProperty("Qualifier")]
        public string Qualifier{ get; set; }

        /// <summary>
        /// 运行函数时的参数，以json格式传入，同步调用最大支持 6MB，异步调用最大支持 128 KB。该字段信息对应函数 [event 入参](https://cloud.tencent.com/document/product/583/9210#.E5.87.BD.E6.95.B0.E5.85.A5.E5.8F.82.3Ca-id.3D.22input.22.3E.3C.2Fa.3E)。
        /// </summary>
        [JsonProperty("ClientContext")]
        public string ClientContext{ get; set; }

        /// <summary>
        /// 异步调用该字段返回为空。
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 函数灰度流量控制调用，以json格式传入，例如{"k":"v"}，注意kv都需要是字符串类型，最大支持的参数长度是1024字节
        /// </summary>
        [JsonProperty("RoutingKey")]
        public string RoutingKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "InvocationType", this.InvocationType);
            this.SetParamSimple(map, prefix + "Qualifier", this.Qualifier);
            this.SetParamSimple(map, prefix + "ClientContext", this.ClientContext);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "RoutingKey", this.RoutingKey);
        }
    }
}

