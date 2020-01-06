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

namespace TencentCloud.Iai.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateFaceResponse : AbstractModel
    {
        
        /// <summary>
        /// 加入成功的人脸数量
        /// </summary>
        [JsonProperty("SucFaceNum")]
        public ulong? SucFaceNum{ get; set; }

        /// <summary>
        /// 加入成功的人脸ID列表
        /// </summary>
        [JsonProperty("SucFaceIds")]
        public string[] SucFaceIds{ get; set; }

        /// <summary>
        /// 每张人脸图片添加结果，-1101 代表未检测到人脸，-1102 代表图片解码失败， 
        /// -1601代表不符合图片质量控制要求, -1604 代表人脸相似度没有超过FaceMatchThreshold。 
        /// 其他非 0 值代表算法服务异常。 
        /// RetCode的顺序和入参中 Images 或 Urls 的顺序一致。
        /// </summary>
        [JsonProperty("RetCode")]
        public long?[] RetCode{ get; set; }

        /// <summary>
        /// 加入成功的人脸索引。索引顺序和入参中 Images 或 Urls 的顺序一致。 
        /// 例， Urls 中 有 3 个 url，第二个 url 失败，则 SucIndexes 值为 [0,2] 。
        /// </summary>
        [JsonProperty("SucIndexes")]
        public ulong?[] SucIndexes{ get; set; }

        /// <summary>
        /// 加入成功的人脸框位置。顺序和入参中 Images 或 Urls 的顺序一致。
        /// </summary>
        [JsonProperty("SucFaceRects")]
        public FaceRect[] SucFaceRects{ get; set; }

        /// <summary>
        /// 人脸识别所用的算法模型版本。
        /// </summary>
        [JsonProperty("FaceModelVersion")]
        public string FaceModelVersion{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SucFaceNum", this.SucFaceNum);
            this.SetParamArraySimple(map, prefix + "SucFaceIds.", this.SucFaceIds);
            this.SetParamArraySimple(map, prefix + "RetCode.", this.RetCode);
            this.SetParamArraySimple(map, prefix + "SucIndexes.", this.SucIndexes);
            this.SetParamArrayObj(map, prefix + "SucFaceRects.", this.SucFaceRects);
            this.SetParamSimple(map, prefix + "FaceModelVersion", this.FaceModelVersion);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

