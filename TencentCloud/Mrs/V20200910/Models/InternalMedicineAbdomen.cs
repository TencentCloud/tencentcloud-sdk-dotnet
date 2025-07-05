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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InternalMedicineAbdomen : AbstractModel
    {
        
        /// <summary>
        /// 内科腹部小结
        /// </summary>
        [JsonProperty("Text")]
        public KeyValueItem Text{ get; set; }

        /// <summary>
        /// 肝脏
        /// </summary>
        [JsonProperty("Liver")]
        public InternalMedicineAbdomenLiver Liver{ get; set; }

        /// <summary>
        /// 胆囊
        /// </summary>
        [JsonProperty("GallBladder")]
        public InternalMedicineAbdomenGallBladder GallBladder{ get; set; }

        /// <summary>
        /// 胰腺
        /// </summary>
        [JsonProperty("Pancreas")]
        public InternalMedicineAbdomenPancreas Pancreas{ get; set; }

        /// <summary>
        /// 脾脏
        /// </summary>
        [JsonProperty("Spleen")]
        public InternalMedicineAbdomenSpleen Spleen{ get; set; }

        /// <summary>
        /// 肾脏
        /// </summary>
        [JsonProperty("Kidney")]
        public InternalMedicineAbdomenKidney Kidney{ get; set; }

        /// <summary>
        /// 腹部其他
        /// </summary>
        [JsonProperty("Others")]
        public KeyValueItem[] Others{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Text.", this.Text);
            this.SetParamObj(map, prefix + "Liver.", this.Liver);
            this.SetParamObj(map, prefix + "GallBladder.", this.GallBladder);
            this.SetParamObj(map, prefix + "Pancreas.", this.Pancreas);
            this.SetParamObj(map, prefix + "Spleen.", this.Spleen);
            this.SetParamObj(map, prefix + "Kidney.", this.Kidney);
            this.SetParamArrayObj(map, prefix + "Others.", this.Others);
        }
    }
}

