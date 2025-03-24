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

namespace TencentCloud.Gs.V20191118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAndroidInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 安卓实例可用区。
        /// ap-guangzhou-3：广州三区
        /// ap-shenzhen-1：深圳一区
        /// ap-xian-ec-1：西安一区
        /// ap-hangzhou-ec-1：杭州一区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 安卓实例类型。
        /// A1：单开
        /// A2：双开
        /// A3：三开
        /// A4：四开
        /// A5：五开
        /// A6：六开
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 当 HostSerialNumbers 不为空时，该参数表示每个宿主机要创建的安卓实例数量；
        /// 当 HostSerialNumbers 为空时，该参数表示要创建安卓实例的总数量，最大值为 100。
        /// </summary>
        [JsonProperty("Number")]
        public ulong? Number{ get; set; }

        /// <summary>
        /// 宿主机 ID 列表。可以指定宿主机 ID 进行创建；也可以不指定由系统自动分配宿主机。
        /// </summary>
        [JsonProperty("HostSerialNumbers")]
        public string[] HostSerialNumbers{ get; set; }

        /// <summary>
        /// 镜像 ID。如果不填，将使用默认的系统镜像
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamArraySimple(map, prefix + "HostSerialNumbers.", this.HostSerialNumbers);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
        }
    }
}

