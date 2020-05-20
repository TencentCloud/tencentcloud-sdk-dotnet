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

namespace TencentCloud.Facefusion.V20181201.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PublicMaterialInfos : AbstractModel
    {
        
        /// <summary>
        /// 素材Id
        /// </summary>
        [JsonProperty("MaterialId")]
        public string MaterialId{ get; set; }

        /// <summary>
        /// 素材状态
        /// </summary>
        [JsonProperty("MaterialStatus")]
        public long? MaterialStatus{ get; set; }

        /// <summary>
        /// 脸型参数P图
        /// </summary>
        [JsonProperty("BlendParamPtu")]
        public long? BlendParamPtu{ get; set; }

        /// <summary>
        /// 五官参数P图
        /// </summary>
        [JsonProperty("PositionParamPtu")]
        public long? PositionParamPtu{ get; set; }

        /// <summary>
        /// 脸型参数优图
        /// </summary>
        [JsonProperty("BlendParamYoutu")]
        public long? BlendParamYoutu{ get; set; }

        /// <summary>
        /// 五官参数优图
        /// </summary>
        [JsonProperty("PositionParamYoutu")]
        public long? PositionParamYoutu{ get; set; }

        /// <summary>
        /// 素材COS地址
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 人脸信息
        /// </summary>
        [JsonProperty("MaterialFaceList")]
        public MaterialFaceList[] MaterialFaceList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaterialId", this.MaterialId);
            this.SetParamSimple(map, prefix + "MaterialStatus", this.MaterialStatus);
            this.SetParamSimple(map, prefix + "BlendParamPtu", this.BlendParamPtu);
            this.SetParamSimple(map, prefix + "PositionParamPtu", this.PositionParamPtu);
            this.SetParamSimple(map, prefix + "BlendParamYoutu", this.BlendParamYoutu);
            this.SetParamSimple(map, prefix + "PositionParamYoutu", this.PositionParamYoutu);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArrayObj(map, prefix + "MaterialFaceList.", this.MaterialFaceList);
        }
    }
}

