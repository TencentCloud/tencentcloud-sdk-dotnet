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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConnectLimitRelation : AbstractModel
    {
        
        /// <summary>
        /// 连接抑制配置
        /// </summary>
        [JsonProperty("ConnectLimitConfig")]
        public ConnectLimitConfig ConnectLimitConfig{ get; set; }

        /// <summary>
        /// 连接抑制关联的实例信息
        /// </summary>
        [JsonProperty("InstanceDetailList")]
        public InstanceRelation[] InstanceDetailList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ConnectLimitConfig.", this.ConnectLimitConfig);
            this.SetParamArrayObj(map, prefix + "InstanceDetailList.", this.InstanceDetailList);
        }
    }
}

