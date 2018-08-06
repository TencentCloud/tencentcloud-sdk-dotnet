/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
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

namespace TencentCloud.Ms.V20180408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceInfo : AbstractModel
    {
        
        /// <summary>
        /// 服务版本，基础版basic,专业版Professional
        /// </summary>
        [JsonProperty("ServiceEdition")]
        public string ServiceEdition{ get; set; }

        /// <summary>
        /// 任务处理完成后的反向通知回调地址,通知为POST请求，post信息{ItemId:"xxxduuyt-ugusg"}
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 提交来源 YYB-应用宝 RDM-rdm MC-控制台 MAC_TOOL-mac工具 WIN_TOOL-window工具
        /// </summary>
        [JsonProperty("SubmitSource")]
        public string SubmitSource{ get; set; }

        /// <summary>
        /// 加固策略编号，如果不传则使用系统默认加固策略。如果指定的plan不存在会返回错误。
        /// </summary>
        [JsonProperty("PlanId")]
        public ulong? PlanId{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceEdition", this.ServiceEdition);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "SubmitSource", this.SubmitSource);
            this.SetParamSimple(map, prefix + "PlanId", this.PlanId);
        }
    }
}

