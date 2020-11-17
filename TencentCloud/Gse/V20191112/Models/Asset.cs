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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Asset : AbstractModel
    {
        
        /// <summary>
        /// 生成包ID
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 生成包名字，最小长度为1，最大长度为64
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// 生成包版本，最小长度为1，最大长度为64
        /// </summary>
        [JsonProperty("AssetVersion")]
        public string AssetVersion{ get; set; }

        /// <summary>
        /// 生成包可运行的操作系统，暂时只支持CentOS7.16
        /// </summary>
        [JsonProperty("OperateSystem")]
        public string OperateSystem{ get; set; }

        /// <summary>
        /// 生成包状态，0代表上传中，1代表上传失败，2代表上传成功
        /// </summary>
        [JsonProperty("Stauts")]
        public long? Stauts{ get; set; }

        /// <summary>
        /// 生成包大小
        /// </summary>
        [JsonProperty("Size")]
        public string Size{ get; set; }

        /// <summary>
        /// 生成包创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 生成包绑定的Fleet个数，最小值为0
        /// </summary>
        [JsonProperty("BindFleetNum")]
        public long? BindFleetNum{ get; set; }

        /// <summary>
        /// 生成包的全局唯一资源标识符
        /// </summary>
        [JsonProperty("AssetArn")]
        public string AssetArn{ get; set; }

        /// <summary>
        /// 生成包支持的操作系统镜像id
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// 生成包支持的操作系统类型
        /// </summary>
        [JsonProperty("OsType")]
        public string OsType{ get; set; }

        /// <summary>
        /// 生成包资源类型，ASSET 或者 IMAGE；ASSET 代表是原有生成包类型，IMAGE 为扩充使用镜像类型
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 镜像资源共享类型，当 ResourceType 为 IMAGE 时该字段有意义，SHARED 表示共享、SHARED_IMAGE 表示未共享；ResourceType 为 ASSET 时这里返回 UNKNOWN_SHARED 用于占位
        /// </summary>
        [JsonProperty("SharingStatus")]
        public string SharingStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "AssetVersion", this.AssetVersion);
            this.SetParamSimple(map, prefix + "OperateSystem", this.OperateSystem);
            this.SetParamSimple(map, prefix + "Stauts", this.Stauts);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "BindFleetNum", this.BindFleetNum);
            this.SetParamSimple(map, prefix + "AssetArn", this.AssetArn);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "SharingStatus", this.SharingStatus);
        }
    }
}

