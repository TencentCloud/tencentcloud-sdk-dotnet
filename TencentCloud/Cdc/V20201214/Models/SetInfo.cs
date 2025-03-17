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

namespace TencentCloud.Cdc.V20201214.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetInfo : AbstractModel
    {
        
        /// <summary>
        /// 云硬盘仓库id
        /// </summary>
        [JsonProperty("SetId")]
        public string SetId{ get; set; }

        /// <summary>
        /// 云硬盘仓库名称
        /// </summary>
        [JsonProperty("SetName")]
        public string SetName{ get; set; }

        /// <summary>
        /// 云硬盘仓库类型
        /// </summary>
        [JsonProperty("SetType")]
        public string SetType{ get; set; }

        /// <summary>
        /// 云硬盘仓库容量
        /// </summary>
        [JsonProperty("SetSize")]
        public float? SetSize{ get; set; }

        /// <summary>
        /// 云硬盘仓库状态
        /// </summary>
        [JsonProperty("SetStatus")]
        public string SetStatus{ get; set; }

        /// <summary>
        /// 云硬盘仓库创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 读流量
        /// </summary>
        [JsonProperty("ReadTraffic")]
        public DetailData ReadTraffic{ get; set; }

        /// <summary>
        /// 写流量
        /// </summary>
        [JsonProperty("WriteTraffic")]
        public DetailData WriteTraffic{ get; set; }

        /// <summary>
        /// 读IO
        /// </summary>
        [JsonProperty("ReadIO")]
        public DetailData ReadIO{ get; set; }

        /// <summary>
        /// 写IO
        /// </summary>
        [JsonProperty("WriteIO")]
        public DetailData WriteIO{ get; set; }

        /// <summary>
        /// 平均等待时间
        /// </summary>
        [JsonProperty("Await")]
        public DetailData Await{ get; set; }

        /// <summary>
        /// 利用率
        /// </summary>
        [JsonProperty("Util")]
        public DetailData Util{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SetId", this.SetId);
            this.SetParamSimple(map, prefix + "SetName", this.SetName);
            this.SetParamSimple(map, prefix + "SetType", this.SetType);
            this.SetParamSimple(map, prefix + "SetSize", this.SetSize);
            this.SetParamSimple(map, prefix + "SetStatus", this.SetStatus);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamObj(map, prefix + "ReadTraffic.", this.ReadTraffic);
            this.SetParamObj(map, prefix + "WriteTraffic.", this.WriteTraffic);
            this.SetParamObj(map, prefix + "ReadIO.", this.ReadIO);
            this.SetParamObj(map, prefix + "WriteIO.", this.WriteIO);
            this.SetParamObj(map, prefix + "Await.", this.Await);
            this.SetParamObj(map, prefix + "Util.", this.Util);
        }
    }
}

