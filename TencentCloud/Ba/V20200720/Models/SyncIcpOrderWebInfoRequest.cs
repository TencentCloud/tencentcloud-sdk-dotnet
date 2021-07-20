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

namespace TencentCloud.Ba.V20200720.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SyncIcpOrderWebInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 备案ICP订单号
        /// </summary>
        [JsonProperty("IcpOrderId")]
        public string IcpOrderId{ get; set; }

        /// <summary>
        /// 订单里的webId
        /// </summary>
        [JsonProperty("SourceWebId")]
        public string SourceWebId{ get; set; }

        /// <summary>
        /// 订单里的webId 数组(如果传入的webIds含有 订单中不包含的webId，会自动跳过)
        /// </summary>
        [JsonProperty("TargetWebIds")]
        public string[] TargetWebIds{ get; set; }

        /// <summary>
        /// 网站信息字段名 数组
        /// </summary>
        [JsonProperty("SyncFields")]
        public string[] SyncFields{ get; set; }

        /// <summary>
        /// 是否先判断同步的网站负责人是否一致 (这里会判断 sitePersonName, sitePersonCerType,sitePersonCerNum三个字段完全一致)  默认:true. 非必要 不建议关闭修改该参数默认值
        /// </summary>
        [JsonProperty("CheckSamePerson")]
        public bool? CheckSamePerson{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IcpOrderId", this.IcpOrderId);
            this.SetParamSimple(map, prefix + "SourceWebId", this.SourceWebId);
            this.SetParamArraySimple(map, prefix + "TargetWebIds.", this.TargetWebIds);
            this.SetParamArraySimple(map, prefix + "SyncFields.", this.SyncFields);
            this.SetParamSimple(map, prefix + "CheckSamePerson", this.CheckSamePerson);
        }
    }
}

