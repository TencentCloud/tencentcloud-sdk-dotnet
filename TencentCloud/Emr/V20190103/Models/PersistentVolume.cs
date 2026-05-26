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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PersistentVolume : AbstractModel
    {
        
        /// <summary>
        /// <p>cbs 存储卷</p>
        /// </summary>
        [JsonProperty("CBSVolumes")]
        public CBSVolume[] CBSVolumes{ get; set; }

        /// <summary>
        /// <p>cfs存储卷</p>
        /// </summary>
        [JsonProperty("CFSVolumes")]
        public CFSVolume[] CFSVolumes{ get; set; }

        /// <summary>
        /// <p>cos 存储卷</p>
        /// </summary>
        [JsonProperty("COSVolumes")]
        public COSVolume[] COSVolumes{ get; set; }

        /// <summary>
        /// <p>存储卷名称（yaml 提交的没有存储卷的类型）</p>
        /// </summary>
        [JsonProperty("StorageVolumeName")]
        public string[] StorageVolumeName{ get; set; }

        /// <summary>
        /// <p>存储卷列表</p>
        /// </summary>
        [JsonProperty("VolumeMounts")]
        public VolumeMount[] VolumeMounts{ get; set; }

        /// <summary>
        /// <p>存储卷详情</p>
        /// </summary>
        [JsonProperty("StorageVolumeDetail")]
        public StorageVolumeDetail[] StorageVolumeDetail{ get; set; }

        /// <summary>
        /// <p>cfs trubo存储卷</p>
        /// </summary>
        [JsonProperty("CFSTurboVolumes")]
        public CFSTurboVolume[] CFSTurboVolumes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "CBSVolumes.", this.CBSVolumes);
            this.SetParamArrayObj(map, prefix + "CFSVolumes.", this.CFSVolumes);
            this.SetParamArrayObj(map, prefix + "COSVolumes.", this.COSVolumes);
            this.SetParamArraySimple(map, prefix + "StorageVolumeName.", this.StorageVolumeName);
            this.SetParamArrayObj(map, prefix + "VolumeMounts.", this.VolumeMounts);
            this.SetParamArrayObj(map, prefix + "StorageVolumeDetail.", this.StorageVolumeDetail);
            this.SetParamArrayObj(map, prefix + "CFSTurboVolumes.", this.CFSTurboVolumes);
        }
    }
}

