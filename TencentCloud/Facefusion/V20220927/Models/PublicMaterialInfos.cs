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

namespace TencentCloud.Facefusion.V20220927.Models
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
        /// 
        /// 字段取值: 
        /// 0   审核中
        /// 1   人工审核通过
        /// 2   人工审核失败
        /// 3   申诉中
        /// 11  申诉成功
        /// 12  申诉失败
        /// 21  机器审核通过
        /// 22  机器审核失败
        /// 31  视频素材预处理成功，素材可用
        /// 32  视频素材预处理失败
        /// 33  角色不在视频中
        /// </summary>
        [JsonProperty("MaterialStatus")]
        public long? MaterialStatus{ get; set; }

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
        public MaterialFaces[] MaterialFaceList{ get; set; }

        /// <summary>
        /// 素材名
        /// </summary>
        [JsonProperty("MaterialName")]
        public string MaterialName{ get; set; }

        /// <summary>
        /// 审核原因
        /// </summary>
        [JsonProperty("AuditResult")]
        public string AuditResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaterialId", this.MaterialId);
            this.SetParamSimple(map, prefix + "MaterialStatus", this.MaterialStatus);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArrayObj(map, prefix + "MaterialFaceList.", this.MaterialFaceList);
            this.SetParamSimple(map, prefix + "MaterialName", this.MaterialName);
            this.SetParamSimple(map, prefix + "AuditResult", this.AuditResult);
        }
    }
}

