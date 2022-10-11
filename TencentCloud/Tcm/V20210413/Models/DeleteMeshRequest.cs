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

    public class DeleteMeshRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要删除的MeshId
        /// </summary>
        [JsonProperty("MeshId")]
        public string MeshId{ get; set; }

        /// <summary>
        /// CLS组件是否被删除
        /// </summary>
        [JsonProperty("NeedDeleteCLS")]
        public bool? NeedDeleteCLS{ get; set; }

        /// <summary>
        /// TMP组件是否被删除
        /// </summary>
        [JsonProperty("NeedDeleteTMP")]
        public bool? NeedDeleteTMP{ get; set; }

        /// <summary>
        /// APM组件是否被删除
        /// </summary>
        [JsonProperty("NeedDeleteAPM")]
        public bool? NeedDeleteAPM{ get; set; }

        /// <summary>
        /// Grafana组件是否被删除
        /// </summary>
        [JsonProperty("NeedDeleteGrafana")]
        public bool? NeedDeleteGrafana{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MeshId", this.MeshId);
            this.SetParamSimple(map, prefix + "NeedDeleteCLS", this.NeedDeleteCLS);
            this.SetParamSimple(map, prefix + "NeedDeleteTMP", this.NeedDeleteTMP);
            this.SetParamSimple(map, prefix + "NeedDeleteAPM", this.NeedDeleteAPM);
            this.SetParamSimple(map, prefix + "NeedDeleteGrafana", this.NeedDeleteGrafana);
        }
    }
}

