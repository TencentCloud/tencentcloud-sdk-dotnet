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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DisassociateKafkaConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 日志配置项ID
        /// 可通过调用[DescribeBusinessLogConfigs](https://cloud.tencent.com/document/product/649/75777)查询已创建的日志配置项列表或登录[控制台](https://console.cloud.tencent.com/tsf/observable/log?rid=1)进行查看
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// 部署组ID列表
        /// 可通过调用[DescribeContainerGroups](https://cloud.tencent.com/document/product/649/36068)或[DescribeGroups](https://cloud.tencent.com/document/product/649/36065)查询已创建的部署组列表或登录[控制台](https://console.cloud.tencent.com/tsf/app-detail?rid=1&id=application-yo7kp9dv&tab=publish&subTab=group)进行查看
        /// </summary>
        [JsonProperty("GroupIds")]
        public string[] GroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamArraySimple(map, prefix + "GroupIds.", this.GroupIds);
        }
    }
}

