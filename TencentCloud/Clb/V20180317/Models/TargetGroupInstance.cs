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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TargetGroupInstance : AbstractModel
    {
        
        /// <summary>
        /// 目标组实例的内网IP
        /// </summary>
        [JsonProperty("BindIP")]
        public string BindIP{ get; set; }

        /// <summary>
        /// 目标组实例的端口，全监听目标组不支持传此字段。
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 目标组实例的权重
        /// 
        /// v2目标组需要配置权重，调用CreateTargetGroup接口创建目标组时该参数与创建接口中的Weight参数必填其一。
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }

        /// <summary>
        /// 目标组实例的新端口，全监听目标组不支持传此字段。
        /// </summary>
        [JsonProperty("NewPort")]
        public ulong? NewPort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BindIP", this.BindIP);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "NewPort", this.NewPort);
        }
    }
}

