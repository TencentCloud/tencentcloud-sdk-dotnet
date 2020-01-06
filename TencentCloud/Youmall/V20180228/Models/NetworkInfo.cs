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

namespace TencentCloud.Youmall.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkInfo : AbstractModel
    {
        
        /// <summary>
        /// 上传带宽，单位Mb/s，-1：未知
        /// </summary>
        [JsonProperty("Upload")]
        public float? Upload{ get; set; }

        /// <summary>
        /// 下载带宽，单位Mb/s，-1：未知
        /// </summary>
        [JsonProperty("Download")]
        public float? Download{ get; set; }

        /// <summary>
        /// 最小延迟，单位ms，-1：未知
        /// </summary>
        [JsonProperty("MinRtt")]
        public float? MinRtt{ get; set; }

        /// <summary>
        /// 平均延迟，单位ms，-1：未知
        /// </summary>
        [JsonProperty("AvgRtt")]
        public float? AvgRtt{ get; set; }

        /// <summary>
        /// 最大延迟，单位ms，-1：未知
        /// </summary>
        [JsonProperty("MaxRtt")]
        public float? MaxRtt{ get; set; }

        /// <summary>
        /// 平均偏差延迟，单位ms，-1：未知
        /// </summary>
        [JsonProperty("MdevRtt")]
        public float? MdevRtt{ get; set; }

        /// <summary>
        /// 丢包率百分比，-1：未知
        /// </summary>
        [JsonProperty("Loss")]
        public float? Loss{ get; set; }

        /// <summary>
        /// 更新时间戳
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// 上报网络状态设备
        /// </summary>
        [JsonProperty("Mac")]
        public string Mac{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Upload", this.Upload);
            this.SetParamSimple(map, prefix + "Download", this.Download);
            this.SetParamSimple(map, prefix + "MinRtt", this.MinRtt);
            this.SetParamSimple(map, prefix + "AvgRtt", this.AvgRtt);
            this.SetParamSimple(map, prefix + "MaxRtt", this.MaxRtt);
            this.SetParamSimple(map, prefix + "MdevRtt", this.MdevRtt);
            this.SetParamSimple(map, prefix + "Loss", this.Loss);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Mac", this.Mac);
        }
    }
}

