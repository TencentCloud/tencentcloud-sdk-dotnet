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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IdcUnit : AbstractModel
    {
        
        /// <summary>
        /// 机房管理单元 ID
        /// </summary>
        [JsonProperty("IdcUnitId")]
        public ulong? IdcUnitId{ get; set; }

        /// <summary>
        /// 机房管理单元名称
        /// </summary>
        [JsonProperty("IdcUnitName")]
        public string IdcUnitName{ get; set; }

        /// <summary>
        /// 围笼列表
        /// </summary>
        [JsonProperty("CageSet")]
        public Cage[] CageSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdcUnitId", this.IdcUnitId);
            this.SetParamSimple(map, prefix + "IdcUnitName", this.IdcUnitName);
            this.SetParamArrayObj(map, prefix + "CageSet.", this.CageSet);
        }
    }
}

