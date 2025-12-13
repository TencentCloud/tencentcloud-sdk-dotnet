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

namespace TencentCloud.Ai3d.V20250513.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitTextureTo3DJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 源3D模型文件。
        /// Type可选值：OBJ，GLB
        /// </summary>
        [JsonProperty("File3D")]
        public File3D File3D{ get; set; }

        /// <summary>
        /// 文生3D，3D内容的描述，中文正向提示词。
        /// 最多支持200个 utf-8 字符。
        /// 文生3D, image、image_url和 prompt必填其一，且prompt和image/image_url不能同时存在。
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// 3D模型纹理参考图 Base64 数据和参考图图 Url。
        /// - Base64 和 Url 必须提供一个，如果都提供以 Url 为准。
        /// - 图片限制：单边分辨率小于4096且大于128，转成 Base64 字符串后小于 10MB，格式支持 jpg、jpeg、png。
        /// </summary>
        [JsonProperty("Image")]
        public Image Image{ get; set; }

        /// <summary>
        /// 是否开启 PBR材质生成，默认 false。
        /// </summary>
        [JsonProperty("EnablePBR")]
        public bool? EnablePBR{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "File3D.", this.File3D);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamObj(map, prefix + "Image.", this.Image);
            this.SetParamSimple(map, prefix + "EnablePBR", this.EnablePBR);
        }
    }
}

